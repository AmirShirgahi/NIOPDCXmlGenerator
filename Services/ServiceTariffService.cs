using Dapper;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NIOPDCXmlGenerator.Services
{
    public class ServiceTariffService
    {
        public IEnumerable<ServiceTariff> GetByRateId(int franchiseRateId)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"SELECT * FROM ServiceTariffs
                        WHERE FranchiseRateID = @franchiseRateId
                        ORDER BY ServiceId";
            return cn.Query<ServiceTariff>(sql, new { franchiseRateId });
        }

        public ServiceTariff? GetById(int tariffId)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"SELECT * FROM ServiceTariffs
                        WHERE TariffId = @tariffId";
            return cn.QueryFirstOrDefault<ServiceTariff>(sql, new { tariffId });
        }

        public bool Exists(int franchiseRateId, int serviceId)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"SELECT COUNT(*) FROM ServiceTariffs
                        WHERE FranchiseRateID = @franchiseRateId AND ServiceId = @serviceId";
            var count = cn.ExecuteScalar<int>(sql, new { franchiseRateId, serviceId });
            return count > 0;
        }

        public bool Exists(int franchiseRateId)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"SELECT COUNT(*) FROM ServiceTariffs
                        WHERE FranchiseRateID = @franchiseRateId ";
            var count = cn.ExecuteScalar<int>(sql, new { franchiseRateId });
            return count > 0;
        }

        public int Insert(ServiceTariff tariff)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"INSERT INTO ServiceTariffs (FranchiseRateID, ServiceId, Amount)
                        VALUES (@FranchiseRateID, @ServiceId, @Amount);
                        SELECT CAST(SCOPE_IDENTITY() as int);";
            return cn.QuerySingle<int>(sql, tariff);
        }

        public void Update(ServiceTariff tariff)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"UPDATE ServiceTariffs
                        SET Amount = @Amount
                        WHERE TariffId = @TariffId";
            cn.Execute(sql, tariff);
        }

        public void Delete(int tariffId)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"DELETE FROM ServiceTariffs
                        WHERE TariffId = @tariffId";
            cn.Execute(sql, new { tariffId });
        }
    }
}