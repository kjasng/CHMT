using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Connection
    {
        private static string connectionString = @"Data Source=DESKTOP-V78H65G\SQLEXPRESS;Initial Catalog=CHMTHM;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetSqlConnection() {
            return new SqlConnection(connectionString);
        }
    }
}
