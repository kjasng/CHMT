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

        // User modify
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

        // Customer modify
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
                    list.Add(new Customer(sqlDataReader.GetInt32(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetInt32(4), sqlDataReader.GetDateTime(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetString(10)));
                }
                sqlConnection.Close();
            }
            return list;
        }

        // Product Category modify
        public List<ProductCategory> ProductCategories(string query)
        {
            List<ProductCategory> list = new List<ProductCategory>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    list.Add(new ProductCategory(sqlDataReader.GetString(1), sqlDataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return list;
        }

        // fetch all customers
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

        // Fetch all users
        public DataTable GetAllProductCategories()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT * FROM ProductCategory"; // hoặc chọn các cột cần thiết
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Product modify
        public List<ProductModel> Products(string query)
        {
            List<ProductModel> list = new List<ProductModel>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    list.Add(new ProductModel(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetInt32(2), sqlDataReader.GetInt32(3), (float)sqlDataReader.GetDouble(4), (float)sqlDataReader.GetDouble(5), sqlDataReader.IsDBNull(6) ? "" : sqlDataReader.GetString(6)));
                }
                sqlConnection.Close();
            }
            return list;
        }

        // Fetch all products
        public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Product";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Get all categories
        public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT * FROM ProductCategory ORDER BY CategoryName";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        
        // Search products by name
        public DataTable SearchProducts(string searchTerm)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Product WHERE ProductName LIKE @searchTerm OR ProductID = @searchTerm";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Search product categories
        public DataTable SearchProductCategories(string searchTerm)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT * FROM ProductCategory WHERE CategoryName LIKE @searchTerm OR Description LIKE @searchTerm";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Execute query (INSERT, UPDATE, DELETE)
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
