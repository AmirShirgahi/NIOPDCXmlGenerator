using Dapper;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace NIOPDCXmlGenerator.Services
{
    public class AuthService
    {
        public User? Authenticate(string username, string password)
        {
            using var cn = DbHelper.GetConnection();
            var user = cn.QueryFirstOrDefault<User>("SELECT * FROM Users WHERE Username=@u", new { u = username });
            if (user == null) return null;
            if (VerifyPassword(password, user.PasswordHash)) return user;
            return null;
        }

        public void CreateUser(string username, string password, string? fullName, bool isAdmin)
        {
            var hash = HashPassword(password);
            using var cn = DbHelper.GetConnection();
            cn.Execute("INSERT INTO Users (Username, PasswordHash, FullName, IsAdmin) VALUES (@u,@p,@f,@a)",
              new { u = username, p = hash, f = fullName, a = isAdmin });
        }

        public void ChangePassword(int userId, string newPassword)
        {
            var hash = HashPassword(newPassword);
            using var cn = DbHelper.GetConnection();
            cn.Execute("UPDATE Users SET PasswordHash=@p WHERE UserId=@id", new { p = hash, id = userId });
        }

        private static string HashPassword(string password)
        {
            using var rng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[16];
            rng.GetBytes(salt);
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
            var hash = pbkdf2.GetBytes(32);
            var result = new byte[1 + salt.Length + hash.Length];
            result[0] = 0x01;
            Buffer.BlockCopy(salt, 0, result, 1, salt.Length);
            Buffer.BlockCopy(hash, 0, result, 1 + salt.Length, hash.Length);
            return Convert.ToBase64String(result);
        }

        private static bool VerifyPassword(string password, string hashed)
        {
            try
            {
                var data = Convert.FromBase64String(hashed);
                if (data[0] != 0x01) return false;
                var salt = new byte[16];
                Buffer.BlockCopy(data, 1, salt, 0, 16);
                var hash = new byte[32];
                Buffer.BlockCopy(data, 1 + 16, hash, 0, 32);
                using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
                var testHash = pbkdf2.GetBytes(32);
                return testHash.SequenceEqual(hash);
            }
            catch
            {
                return false;
            }
        }
    }
}
