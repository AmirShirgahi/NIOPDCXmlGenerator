using Dapper;
using NIOPDCXmlGenerator.Data;
using NIOPDCXmlGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOPDCXmlGenerator.Services
{
    public class UserService
    {
        public IEnumerable<User> GetAll()
        {
            using var cn = DbHelper.GetConnection();
            return cn.Query<User>("SELECT * FROM Users ORDER BY Username");
        }

        public void Delete(int userId)
        {
            using var cn = DbHelper.GetConnection();
            cn.Execute("DELETE FROM Users WHERE UserId=@id", new { id = userId });
        }
    }
}
