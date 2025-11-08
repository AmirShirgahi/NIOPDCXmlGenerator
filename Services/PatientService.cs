using Dapper;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using System.Collections.Generic;

namespace NIOPDCXmlGenerator.Services
{
    public class PatientService
    {
        public IEnumerable<Patient> GetAll()
        {
            using var cn = DbHelper.GetConnection();
            return cn.Query<Patient>("SELECT * FROM Patients ORDER BY LastName, FirstName");
        }

        public Patient? GetById(int id)
        {
            using var cn = DbHelper.GetConnection();
            return cn.QueryFirstOrDefault<Patient>("SELECT * FROM Patients WHERE PatientId=@id", new { id });
        }

        public int Insert(Patient p)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"INSERT INTO Patients (PersonnelCode, FirstName, LastName, NationalCode, Mobile, IsRetired,Gender)
                  VALUES (@PersonnelCode, @FirstName, @LastName, @NationalCode, @Mobile, @IsRetired,@Gender);
                  SELECT CAST(SCOPE_IDENTITY() as int);";
            return cn.QuerySingle<int>(sql, p);
        }

        public void Update(Patient p)
        {
            using var cn = DbHelper.GetConnection();
            var sql = @"UPDATE Patients SET PersonnelCode=@PersonnelCode, FirstName=@FirstName, LastName=@LastName,
                  NationalCode=@NationalCode, Mobile=@Mobile, IsRetired=@IsRetired,Gender=@Gender, UpdatedAt=GETDATE()
                  WHERE PatientId=@PatientId";
            cn.Execute(sql, p);
        }

        public void Delete(int id)
        {
            using var cn = DbHelper.GetConnection();
            cn.Execute("DELETE FROM Patients WHERE PatientId=@id", new { id });
        }

        public Patient? GetBypersonnelCode(string personnelCode)
        {
            using var cn = DbHelper.GetConnection();
                var sql = @"SELECT TOP 1 * FROM Patients 
                WHERE PersonnelCode = @PersonnelCode";
                return cn.QueryFirstOrDefault<Patient>(sql, new { PersonnelCode = personnelCode });
        }
    }
}
