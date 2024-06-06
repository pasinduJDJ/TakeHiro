using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHiro
{
    internal class Customers
    {
        // Properties representing the customer's attributes
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerNumber  { get; set; } = string.Empty;
        public string Location  { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;

        // Connection string to connect to the MySQL database
        private string _connectionString;

        public Customers(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
        // Method to save a new customer to the database
        public void SaveCustomer()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Customer (CustomerName, ContactNumber, Location, Username, Password) VALUES (@CustomerName, @ContactNumber, @Location, @Username, @Password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                cmd.Parameters.AddWithValue("@ContactNumber", CustomerNumber);
                cmd.Parameters.AddWithValue("@Location", Location);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();
            }
        }

        // Method to validate customer login credentials
        // Returns the CustomerID if the credentials are valid, otherwise returns null
        public int? ValidateCustomerLogin(string username, string password)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT CustomerID FROM Customer WHERE Username = @Username AND Password = @Password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
