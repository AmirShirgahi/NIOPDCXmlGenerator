using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;

namespace NIOPDCXmlGenerator.Services
{
    /// <summary>
    /// سرویس مدیریت ویزیت ها و جزئیات آنها
    /// همه عملیات پایه با Dapper انجام می‌شود و درج/به‌روزرسانی جزئیات در یک تراکنش است.
    /// </summary>
    public class VisitService
    {
        private readonly ServiceService _serviceService = new ServiceService();
        private readonly FranchiseService _franchiseService = new FranchiseService();
        private readonly PatientService _patientService = new PatientService();

        /// <summary>
        /// DTO کوچک برای ورودی یک سطر خدمت قبل از محاسبه و درج
        /// </summary>
        public class AddDetailRequest
        {
            public int ServiceId { get; set; }
            public int Quantity { get; set; }
            public DateTime VisitDate { get; set; } // میلادی
        }

        /// <summary>
        /// باز می‌گرداند همه ویزیت‌ها به همراه کد پرسنلی و نام بیمار (برای نمایش در لیست)
        /// </summary>
        public IEnumerable<VisitListItem> GetAllVisits()
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"
        SELECT v.VisitId, v.PatientId, v.VisitDate, v.BookletExpiryDate, v.PrescriptionPageNo,
               v.TotalQuantity, v.TotalPatientShare, v.TotalCompanyShare, v.TotalAmount, v.CreatedAt,
               p.PersonnelCode, (ISNULL(p.FirstName,'') + ' ' + ISNULL(p.LastName,'')) AS PatientName
        FROM Visits v
        INNER JOIN Patients p ON v.PatientId = p.PatientId
        ORDER BY v.VisitDate DESC, v.VisitId DESC";
            return cn.Query<VisitListItem>(sql);
        }

        /// <summary>
        /// گرفتن سرفصل و جزئیات یک ویزیت
        /// </summary>
        public (Visit visit, IEnumerable<VisitDetail> details) GetVisitWithDetails(int visitId)
        {
            using var cn = DbHelper.GetConnection();
            var visit = cn.QueryFirstOrDefault<Visit>("SELECT * FROM Visits WHERE VisitId = @id", new { id = visitId });
            var details = cn.Query<VisitDetail>("SELECT * FROM VisitDetails WHERE VisitId = @id ORDER BY VisitDetailId", new { id = visitId });
            return (visit, details);
        }

        /// <summary>
        /// درج یا به‌روزرسانی سرفصل و جزئیات ویزیت در یک تراکنش
        /// اگر visitIdToUpdate مشخص باشد، روش فعلی این پیاده‌سازی، حذف جزئیات فعلی و درج مجدد جزئیات جدید است.
        /// </summary>
        public int InsertVisitWithDetails(int patientId, DateTime visitDate, DateTime? bookletExpiry, string prescriptionPageNo,
                                          IEnumerable<AddDetailRequest> details, bool isRetired, int? visitIdToUpdate = null)
        {
            using var cn = DbHelper.GetConnection();
            cn.Open();
            using var tx = cn.BeginTransaction();

            try
            {
                // محاسبه جزئیات (unitAmount از ServiceTariffs، درصد فرانشیز از FranchiseRates)
                var computedDetails = new List<VisitDetail>();
                long totalPatientShare = 0;
                long totalCompanyShare = 0;
                int totalQty = 0;

                foreach (var d in details)
                {
                    var unitAmount = _serviceService.GetTariffForDate(d.ServiceId, d.VisitDate);
                    if (!unitAmount.HasValue)
                        throw new InvalidOperationException($"برای خدمت با آی‌دی {d.ServiceId} در تاریخ {d.VisitDate:yyyy-MM-dd} تعرفه تعریف نشده است.");

                    var percent = _franchiseService.GetPercentageForDate(isRetired, d.VisitDate);
                    if (!percent.HasValue)
                        throw new InvalidOperationException($"درصد فرانشیز برای نوع بیمار در تاریخ {d.VisitDate:yyyy-MM-dd} تعریف نشده است.");

                    long qty = d.Quantity;
                    long total = unitAmount.Value * qty;
                    long patientShare = (long)Math.Round(total * (percent.Value / 100m));
                    long companyShare = total - patientShare;

                    totalPatientShare += patientShare;
                    totalCompanyShare += companyShare;
                    totalQty += (int)qty;

                    // در اینجا TariffId را هم تلاش می‌کنیم بدست آوریم (اگر نیاز به مرجع داشته باشی)
                    // سرویس ServiceService می‌تواند متدی برای گرفتن TariffId همراه Amount ارائه دهد
                    int? tariffId = GetTariffIdForServiceOnDate(d.ServiceId, d.VisitDate, cn, tx);

                    computedDetails.Add(new VisitDetail
                    {
                        ServiceId = d.ServiceId,
                        TariffId = tariffId,
                        Quantity = (int)qty,
                        UnitAmount = unitAmount.Value,
                        PatientShare = patientShare,
                        CompanyShare = companyShare,
                        TotalAmount = total
                    });
                }

                int visitId;
                if (visitIdToUpdate.HasValue)
                {
                    // حذف جزئیات قبلی و به‌روزرسانی سرفصل
                    cn.Execute("DELETE FROM VisitDetails WHERE VisitId=@id", new { id = visitIdToUpdate.Value }, tx);

                    var updateSql = @"
            UPDATE Visits SET PatientId=@PatientId, VisitDate=@VisitDate, BookletExpiryDate=@BookletExpiryDate,
                              PrescriptionPageNo=@PrescriptionPageNo, TotalQuantity=@TotalQuantity,
                              TotalPatientShare=@TotalPatientShare, TotalCompanyShare=@TotalCompanyShare,
                              TotalAmount=@TotalAmount, CreatedAt=ISNULL(CreatedAt, GETDATE())
            WHERE VisitId=@VisitId";
                    cn.Execute(updateSql, new
                    {
                        PatientId = patientId,
                        VisitDate = visitDate.Date,
                        BookletExpiryDate = bookletExpiry?.Date,
                        PrescriptionPageNo = prescriptionPageNo,
                        TotalQuantity = totalQty,
                        TotalPatientShare = totalPatientShare,
                        TotalCompanyShare = totalCompanyShare,
                        TotalAmount = totalPatientShare + totalCompanyShare,
                        VisitId = visitIdToUpdate.Value
                    }, tx);

                    visitId = visitIdToUpdate.Value;
                }
                else
                {
                    var insertVisitSql = @"
            INSERT INTO Visits (PatientId, VisitDate, BookletExpiryDate, PrescriptionPageNo, TotalQuantity, TotalPatientShare, TotalCompanyShare, TotalAmount)
            VALUES (@PatientId, @VisitDate, @BookletExpiryDate, @PrescriptionPageNo, @TotalQuantity, @TotalPatientShare, @TotalCompanyShare, @TotalAmount);
            SELECT CAST(SCOPE_IDENTITY() as int);";
                    visitId = cn.QuerySingle<int>(insertVisitSql, new
                    {
                        PatientId = patientId,
                        VisitDate = visitDate.Date,
                        BookletExpiryDate = bookletExpiry?.Date,
                        PrescriptionPageNo = prescriptionPageNo,
                        TotalQuantity = totalQty,
                        TotalPatientShare = totalPatientShare,
                        TotalCompanyShare = totalCompanyShare,
                        TotalAmount = totalPatientShare + totalCompanyShare
                    }, tx);
                }

                // درج جزئیات
                var insertDetailSql = @"
          INSERT INTO VisitDetails (VisitId, ServiceId, TariffId, Quantity, UnitAmount, PatientShare, CompanyShare, TotalAmount)
          VALUES (@VisitId, @ServiceId, @TariffId, @Quantity, @UnitAmount, @PatientShare, @CompanyShare, @TotalAmount);";

                foreach (var vd in computedDetails)
                {
                    cn.Execute(insertDetailSql, new
                    {
                        VisitId = visitId,
                        vd.ServiceId,
                        vd.TariffId,
                        vd.Quantity,
                        vd.UnitAmount,
                        vd.PatientShare,
                        vd.CompanyShare,
                        vd.TotalAmount
                    }, tx);
                }

                tx.Commit();
                return visitId;
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        /// <summary>
        /// حذف یک ویزیت و جزئیاتش
        /// </summary>
        public void DeleteVisit(int visitId)
        {
            using var cn = DbHelper.GetConnection();
            cn.Execute("DELETE FROM VisitDetails WHERE VisitId=@id; DELETE FROM Visits WHERE VisitId=@id;", new { id = visitId });
        }

        /// <summary>
        /// جستجو/فیلتر ویزیت‌ها بر اساس مقادیر اختیاری (مناسب برای پیاده‌سازی سمت سرویس/سرور)
        /// </summary>
        public IEnumerable<VisitListItem> GetVisitsFiltered(string personnelCode = null, string patientName = null, DateTime? from = null, DateTime? to = null)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"
        SELECT v.VisitId, v.PatientId, v.VisitDate, v.BookletExpiryDate, v.PrescriptionPageNo,
               v.TotalQuantity, v.TotalPatientShare, v.TotalCompanyShare, v.TotalAmount, v.CreatedAt,
               p.PersonnelCode, (ISNULL(p.FirstName,'') + ' ' + ISNULL(p.LastName,'')) AS PatientName
        FROM Visits v
        INNER JOIN Patients p ON v.PatientId = p.PatientId
        WHERE 1=1 ";
            var parameters = new DynamicParameters();
            if (!string.IsNullOrWhiteSpace(personnelCode))
            {
                sql += " AND p.PersonnelCode LIKE @pers";
                parameters.Add("pers", $"%{personnelCode}%");
            }
            if (!string.IsNullOrWhiteSpace(patientName))
            {
                sql += " AND (p.FirstName + ' ' + ISNULL(p.LastName,'')) LIKE @name";
                parameters.Add("name", $"%{patientName}%");
            }
            if (from.HasValue)
            {
                sql += " AND v.VisitDate >= @from";
                parameters.Add("from", from.Value.Date);
            }
            if (to.HasValue)
            {
                sql += " AND v.VisitDate <= @to";
                parameters.Add("to", to.Value.Date);
            }
            sql += " ORDER BY v.VisitDate DESC, v.VisitId DESC";
            return cn.Query<VisitListItem>(sql, parameters);
        }

        /// <summary>
        /// تلاش برای دریافت TariffId برای یک سرویس در تاریخ مشخص؛ اگر موجود نبود null برمی‌گرداند.
        /// برای خوانایی و جلوگیری از وابستگی سرویس‌ها، این متد یک کوئری ساده به جدول ServiceTariffs می‌زند.
        /// </summary>
        private int? GetTariffIdForServiceOnDate(int serviceId, DateTime date, IDbConnection cn = null, IDbTransaction tx = null)
        {
            var externalConnection = cn != null;
            if (!externalConnection) cn = DbHelper.GetConnection();
            var sql = @"SELECT TOP 1 TariffId FROM ServiceTariffs WHERE ServiceId=@sid AND FromDate <= @d AND ToDate >= @d ORDER BY FromDate DESC";
            var tariffId = cn.QueryFirstOrDefault<int?>(sql, new { sid = serviceId, d = date.Date }, tx);
            if (!externalConnection) cn.Dispose();
            return tariffId;
        }
    }
}

