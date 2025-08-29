using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Modify
    {
        public Modify() 
        {
        }

        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        public List<Users> Users(string query) 
        { 
            List<Users> list = new List<Users>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read()) {

                    list.Add(new Users(sqlDataReader.GetString(1), sqlDataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
                return list;
        }

        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                return cmd.ExecuteNonQuery(); // số dòng bị ảnh hưởng
            }
        }
    }
}
