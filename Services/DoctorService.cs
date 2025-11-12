using Dapper;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace NIOPDCXmlGenerator.Services
{
    public class DoctorService
    {
        private readonly string _connectionString;

        public DoctorService()
        {
            _connectionString = DbHelper.GetConnection().ConnectionString;
        }

        public List<Doctor> GetAll(bool ShowDisabledDoctors=true)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<Doctor>($"SELECT * FROM Doctors {(!ShowDisabledDoctors ? string.Format("WHERE IsActive=1"):string.Empty)}").ToList();
        }

        public Doctor GetByNPCode(string npCode)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.QueryFirstOrDefault<Doctor>(
                "SELECT * FROM Doctors WHERE NPCode = @NPCode", new { NPCode = npCode });
        }

        public void Insert(Doctor doctor)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Execute(@"
            INSERT INTO Doctors (NPCode, FirstName, LastName, NationalCode, Mobile, Gender,Specialty, IsActive)
            VALUES (@NPCode, @FirstName, @LastName, @NationalCode, @Mobile, @Gender,@Specialty, @IsActive)", doctor);
        }

        public void Update(Doctor doctor)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Execute(@"
            UPDATE Doctors SET
                FirstName = @FirstName,
                LastName = @LastName,
                NationalCode = @NationalCode,
                Mobile = @Mobile,
                Gender = @Gender,
                Specialty = @Specialty,
                IsActive = @IsActive,
                UpdatedAt = GETDATE()
            WHERE NPCode = @NPCode", doctor);
        }

        public void Delete(string npCode)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Execute("DELETE FROM Doctors WHERE NPCode = @NPCode", new { NPCode = npCode });
        }
    }

}