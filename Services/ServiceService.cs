using System;
using System.Collections.Generic;
using Dapper;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;

namespace NIOPDCXmlGenerator.Services
{
    public class ServiceService
    {
        public IEnumerable<ServiceItem> GetAllServices()
        {
            using var cn = DbHelper.GetConnection();
            return cn.Query<ServiceItem>("SELECT * FROM Services ORDER BY Title");
        }

        public ServiceItem? GetServiceById(int serviceId)
        {
            using var cn = DbHelper.GetConnection();
            return cn.QueryFirstOrDefault<ServiceItem>("SELECT * FROM Services WHERE ServiceId = @id", new { id = serviceId });
        }

        public int InsertService(ServiceItem s)
        {
            using var cn = DbHelper.GetConnection();
            var sql = "INSERT INTO Services (Title, IsActive) VALUES (@Title, @IsActive); SELECT CAST(SCOPE_IDENTITY() as int);";
            return cn.QuerySingle<int>(sql, s);
        }

        public void UpdateService(ServiceItem s)
        {
            using var cn = DbHelper.GetConnection();
            var sql = "UPDATE Services SET Title=@Title, IsActive=@IsActive WHERE ServiceId=@ServiceId";
            cn.Execute(sql, s);
        }

        public void DeleteService(int serviceId)
        {
            using var cn = DbHelper.GetConnection();
            cn.Execute("DELETE FROM Services WHERE ServiceId=@id", new { id = serviceId });
        }

        public IEnumerable<ServiceTariff> GetTariffsForService(int serviceId)
        {
            using var cn = DbHelper.GetConnection();
            return cn.Query<ServiceTariff>("SELECT * FROM ServiceTariffs WHERE ServiceId=@serviceId ORDER BY FromDate", new { serviceId });
        }
        public IEnumerable<ServiceItem> GetActiveServices()
        {
            using var cn = DbHelper.GetConnection();
            return cn.Query<ServiceItem>("SELECT * FROM Services WHERE IsActive=1 ORDER BY ServiceId");
        }


        public ServiceTariff? GetTariffById(int id)
        {
            using var cn = DbHelper.GetConnection();
            return cn.QueryFirstOrDefault<ServiceTariff>("SELECT * FROM ServiceTariffs WHERE TariffId=@id", new { id });
        }

        public bool HasTariffOverlap(int serviceId, DateTime from, DateTime to, int? excludeTariffId = null)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"SELECT COUNT(1) FROM ServiceTariffs
                  WHERE ServiceId = @serviceId
                    AND NOT (ToDate < @FromDate OR FromDate > @ToDate)";
            if (excludeTariffId.HasValue) sql += " AND TariffId <> @ExcludeId";
            return cn.ExecuteScalar<int>(sql, new { serviceId, FromDate = from.Date, ToDate = to.Date, ExcludeId = excludeTariffId }) > 0;
        }

        public int InsertTariff(ServiceTariff t)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"INSERT INTO ServiceTariffs (ServiceId, FromDate, ToDate, Amount)
                  VALUES (@ServiceId, @FromDate, @ToDate, @Amount);
                  SELECT CAST(SCOPE_IDENTITY() as int);";
            return cn.QuerySingle<int>(sql, t);
        }

        public void UpdateTariff(ServiceTariff t)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"UPDATE ServiceTariffs SET FromDate=@FromDate, ToDate=@ToDate, Amount=@Amount, UpdatedAt=GETDATE()
                  WHERE TariffId=@TariffId";
            cn.Execute(sql, t);
        }

        public void DeleteTariff(int tariffId)
        {
            using var cn = DbHelper.GetConnection();
            cn.Execute("DELETE FROM ServiceTariffs WHERE TariffId=@id", new { id = tariffId });
        }

        /// <summary>
        /// برمی‌گرداند مبلغ (Amount) برای سرویس در تاریخ مشخص. اگر تعریفی وجود نداشت، null باز می‌گردد.
        /// </summary>
        public long? GetTariffForDate(int serviceId, DateTime date)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"SELECT TOP 1 Amount FROM ServiceTariffs
                  WHERE ServiceId=@sid AND FromDate<=@d AND ToDate>=@d
                  ORDER BY FromDate DESC";
            return cn.QueryFirstOrDefault<long?>(sql, new { sid = serviceId, d = date.Date });
        }

        /// <summary>
        /// برمی‌گرداند تمام تعرفه‌هایی که با تاریخ مشخص تداخل دارند (برای نمایش خطا یا جزئیات).
        /// </summary>
        public IEnumerable<ServiceTariff> GetOverlappingTariffs(int serviceId, DateTime from, DateTime to)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"SELECT * FROM ServiceTariffs
                  WHERE ServiceId=@serviceId
                    AND NOT (ToDate < @FromDate OR FromDate > @ToDate)
                  ORDER BY FromDate";
            return cn.Query<ServiceTariff>(sql, new { serviceId, FromDate = from.Date, ToDate = to.Date });
        }

        public IEnumerable<ServiceItem> GetRemainServicesByrateId(int rateId)
        {
            using var cn = DbHelper.GetConnection();
            return cn.Query<ServiceItem>("SELECT * FROM Services WHERE IsActive=1 and ServiceId not in (SELECT ServiceId FROM ServiceTariffs WHERE FranchiseRateID=@_rateId ) ORDER BY ServiceId", new { _rateId = rateId });

        }
    }
}
