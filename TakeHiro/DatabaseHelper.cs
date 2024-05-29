using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace TakeHiro
{
    internal class DatabaseHelper
    {
        private string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
        // Save Customer Details 
        public void SaveCustomer(string customerName, string contactNumber, string location, string username, string password)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Customer (CustomerName, ContactNumber, Location, Username, Password) VALUES (@CustomerName, @ContactNumber, @Location, @Username, @Password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();
            }
        }

        // Save Driver Details 
        public void SaveDriver(string name, string contactNumber, bool availability)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Driver (Name, ContactNumber, Availability) VALUES (@Name, @ContactNumber, @Availability)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@Availability", availability);

                cmd.ExecuteNonQuery();
            }
        }

        // Save Car Details 
        public void SaveCar(string model, string plateNumber, bool availability)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Car (Model, PlateNumber, Availability) VALUES (@Model, @PlateNumber, @Availability)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                cmd.Parameters.AddWithValue("@Availability", availability);

                cmd.ExecuteNonQuery();
            }
        }

        internal void SaveCar()
        {
            throw new NotImplementedException();
        }

        public void SaveOrder(string customerName, string driverID, string carID, string destination, string location, string orderDate)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO `Order` (CustomerID, DriverID, CarID, Destination, Location, OrderDate) VALUES (@CustomerID, @DriverID, @CarID, @Destination, @Location, @OrderDate)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerName);
                cmd.Parameters.AddWithValue("@DriverID", driverID);
                cmd.Parameters.AddWithValue("@CarID", carID);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate); // Add this parameter

                cmd.ExecuteNonQuery();
            }
        }


        // Retrieve all car data
        public DataTable GetAllCars()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Car";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        // Retrieve all car data
        public DataTable GetAllDrivers()
        {
            DataTable dtD = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Driver";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dtD);
            }
            return dtD;
        }
        // Retrieve all Orders data
        public DataTable GetAllOrders()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM `Order`";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        // Retrive Avilabel Drivers 
        public DataTable GetAvailableDrivers()
        {
            DataTable dtD = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Driver WHERE Availability = 1"; 
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dtD);
            }
            return dtD;
        }
        // Retrive Avilabel Cars 
        public DataTable GetAvailableCars()
        {
            DataTable dtC = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Car WHERE Availability = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dtC);
            }
            return dtC;
        }

        // Count of Avilabel Drivers 
        public int GetAvailableDriverCount()
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Driver WHERE Availability = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return count;
        }

        // Count of Avilabel Cars 
        public int GetAvailabelCarCount()
        {
            int count = 0;
            using (MySqlConnection conn=GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Car WHERE Availability =1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());

            }
            return count;
        }



    }
}
