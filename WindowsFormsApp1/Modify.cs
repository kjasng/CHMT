using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

                    list.Add(new Users(sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetInt32(3)));
                }
                sqlConnection.Close();
            }
                return list;
        }

        public List<Customer> Customers(string query)
        {
            List<Customer> list = new List<Customer>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    list.Add(new Customer(sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetInt32(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9)));
                }
                sqlConnection.Close();
            }
            return list;
        }

        public DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Customers"; // hoặc chọn các cột cần thiết
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
