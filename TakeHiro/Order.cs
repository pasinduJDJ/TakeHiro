using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHiro
{
    internal class Order
    {
        // Properties representing the order's attributes
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int DriverID { get; set; } 
        public int CarID { get; set; }
        public string Destination { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }

        // Connection string to connect to the MySQL database
        private string _connectionString;

        public Order(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
        // Method to save a new order to the database
        public void SaveOrder()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO `Order` (CustomerID, DriverID, CarID, Destination, Location, OrderDate) VALUES (@CustomerID, @DriverID, @CarID, @Destination, @Location, @OrderDate)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
                cmd.Parameters.AddWithValue("@CarID", CarID);
                cmd.Parameters.AddWithValue("@Destination", Destination);
                cmd.Parameters.AddWithValue("@Location", Location);
                cmd.Parameters.AddWithValue("@OrderDate", OrderDate);

                cmd.ExecuteNonQuery();
            }
        }
        // Method to get all orders from the database
        public DataTable GetAllOrders()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM `Order`";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Method to get the count of orders in the database
        public int GetCountOrders()
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM `Order`";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return count;
        }
    }
}
