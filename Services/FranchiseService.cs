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
    /// سرویس مدیریت جدول FranchiseRates
    /// ساختار جدول مورد انتظار:
    /// RateId, RetiredPercentage, EmployeePercentage, FromDate, ToDate, CreatedAt, UpdatedAt
    /// </summary>
    public class FranchiseService
    {
        /// <summary>
        /// بازگرداندن تمام رکوردها مرتب شده بر اساس FromDate
        /// </summary>
        public IEnumerable<FranchiseRate> GetAll()
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"SELECT RateId, RetiredPercentage, EmployeePercentage, FromDate, ToDate, CreatedAt, UpdatedAt
                  FROM FranchiseRates
                  ORDER BY FromDate";
            return cn.Query<FranchiseRate>(sql);
        }

        /// <summary>
        /// گرفتن رکورد بر اساس شناسه
        /// </summary>
        public FranchiseRate? GetById(int rateId)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"SELECT RateId, RetiredPercentage, EmployeePercentage, FromDate, ToDate, CreatedAt, UpdatedAt
                  FROM FranchiseRates
                  WHERE RateId = @id";
            return cn.QueryFirstOrDefault<FranchiseRate>(sql, new { id = rateId });
        }

        /// <summary>
        /// درج رکورد جدید؛ برمی‌گرداند RateId ایجاد شده
        /// </summary>
        public int Insert(FranchiseRate model)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"
        INSERT INTO FranchiseRates (RetiredPercentage, EmployeePercentage, FromDate, ToDate, CreatedAt)
        VALUES (@RetiredPercentage, @EmployeePercentage, @FromDate, @ToDate, GETDATE());
        SELECT CAST(SCOPE_IDENTITY() as int);";
            return cn.QuerySingle<int>(sql, new
            {
                model.RetiredPercentage,
                model.EmployeePercentage,
                FromDate = model.FromDate.Date,
                ToDate = model.ToDate.Date
            });
        }

        /// <summary>
        /// به‌روزرسانی رکورد موجود
        /// </summary>
        public void Update(FranchiseRate model)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"
        UPDATE FranchiseRates
        SET RetiredPercentage = @RetiredPercentage,
            EmployeePercentage = @EmployeePercentage,
            FromDate = @FromDate,
            ToDate = @ToDate,
            UpdatedAt = GETDATE()
        WHERE RateId = @RateId";
            cn.Execute(sql, new
            {
                model.RetiredPercentage,
                model.EmployeePercentage,
                FromDate = model.FromDate.Date,
                ToDate = model.ToDate.Date,
                model.RateId
            });
        }

        /// <summary>
        /// حذف رکورد
        /// </summary>
        public void Delete(int rateId)
        {
            using var cn = DbHelper.GetConnection();
            cn.Execute("DELETE FROM FranchiseRates WHERE RateId = @id", new { id = rateId });
        }

        /// <summary>
        /// بررسی همپوشانی بازه‌ها
        /// اگر excludeRateId مشخص شود آن رکورد در بررسی نادیده گرفته می‌شود (برای update)
        /// منطق: اگر بازه جدید با هر رکورد دیگری تداخلی داشته باشد، true برمی‌گرداند
        /// </summary>
        public bool HasOverlap(DateTime fromDate, DateTime toDate, int? excludeRateId = null)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"
        SELECT COUNT(1) FROM FranchiseRates
        WHERE NOT (ToDate < @FromDate OR FromDate > @ToDate)";
            if (excludeRateId.HasValue) sql += " AND RateId <> @ExcludeId";
            var count = cn.ExecuteScalar<int>(sql, new { FromDate = fromDate.Date, ToDate = toDate.Date, ExcludeId = excludeRateId });
            return count > 0;
        }

        /// <summary>
        /// گرفتن درصد مناسب برای یک تاریخ و نوع بیمار (isRetired)
        /// برمی‌گرداند مقدار decimal? که null به معنی عدم تعریف در آن تاریخ است.
        /// </summary>
        public decimal? GetPercentageForDate(bool isRetired, DateTime date)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"
        SELECT TOP 1 RetiredPercentage, EmployeePercentage
        FROM FranchiseRates
        WHERE FromDate <= @d AND ToDate >= @d
        ORDER BY FromDate DESC, RateId DESC";
            var rec = cn.QueryFirstOrDefault(sql, new { d = date.Date });
            if (rec == null) return null;

            // rec.retiredpercentage و rec.employeepercentage ممکن است به صورت dynamic خوانده شوند
            decimal? retired = rec.RetiredPercentage == null ? (decimal?)null : (decimal)rec.RetiredPercentage;
            decimal? employee = rec.EmployeePercentage == null ? (decimal?)null : (decimal)rec.EmployeePercentage;

            return isRetired ? retired : employee;
        }

        /// <summary>
        /// گرفتن رکورد (FranchiseRate) که بازه‌ای شامل تاریخ مشخص است؛ null اگر وجود نداشت.
        /// این متد ممکن است وقتی نیاز داشته باشی هر دو درصد را نمایش دهی مفید باشد.
        /// </summary>
        public FranchiseRate? GetByDate(DateTime date)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"
        SELECT TOP 1 RateId, RetiredPercentage, EmployeePercentage, FromDate, ToDate, CreatedAt, UpdatedAt
        FROM FranchiseRates
        WHERE FromDate <= @d AND ToDate >= @d
        ORDER BY FromDate DESC, RateId DESC";
            return cn.QueryFirstOrDefault<FranchiseRate>(sql, new { d = date.Date });
        }

        /// <summary>
        /// (اختیاری) گرفتن همه بازه‌هایی که با یک بازه مشخص تداخل دارند (برای نمایش پیام خطا و جزئیات)
        /// </summary>
        public IEnumerable<FranchiseRate> GetOverlappingRanges(DateTime fromDate, DateTime toDate, int? excludeRateId = null)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"
        SELECT RateId, RetiredPercentage, EmployeePercentage, FromDate, ToDate, CreatedAt, UpdatedAt
        FROM FranchiseRates
        WHERE NOT (ToDate < @FromDate OR FromDate > @ToDate)";
            if (excludeRateId.HasValue) sql += " AND RateId <> @ExcludeId";
            return cn.Query<FranchiseRate>(sql, new { FromDate = fromDate.Date, ToDate = toDate.Date, ExcludeId = excludeRateId });
        }
    }
}
