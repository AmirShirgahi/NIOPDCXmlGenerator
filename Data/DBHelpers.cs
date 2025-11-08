using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOPDCXmlGenerator.Data
{
    public static class DbHelper
    {
        private static string ConnectionString =>
          ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
