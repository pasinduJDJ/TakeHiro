using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TakeHiro
{
    internal class Driver
    {
        // Properties representing the driver's attributes
        public int DriverID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public bool Availability { get; set; }
        // Connection string to connect to the MySQL database
        private string _connectionString;

        public Driver(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
        // Method to save a new driver to the database
        public void SaveDriver()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Driver (Name, ContactNumber, Availability) VALUES (@Name, @ContactNumber, @Availability)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                    cmd.Parameters.AddWithValue("@Availability", Availability);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Method to get all drivers from the database
        public DataTable GetAllDrivers()
        {
            var dtD = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Driver";
                using (var cmd = new MySqlCommand(query, conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dtD);
                }
            }
            return dtD;
        }
        // Method to get all available drivers from the database
        public DataTable GetAvailableDrivers()
        {
            var dtD = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Driver WHERE Availability = 1";
                using (var cmd = new MySqlCommand(query, conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dtD);
                }
            }
            return dtD;
        }
        // Method to get the count of available drivers in the database
        public int GetAvailableDriverCount()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Driver WHERE Availability = 1";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        // Method to get the total count of drivers in the database
        public int GetCountAllDrivers()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Driver";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        // Method to update driver details in the database
        public void UpdateDriver()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Driver SET Name = @Name, ContactNumber = @ContactNumber, Availability = @Availability WHERE DriverID = @DriverID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);   
                    cmd.Parameters.AddWithValue("@Availability", Availability);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Overloaded method to update driver availability in the database
        public void UpdateDriver(int driverId, bool availability)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Driver SET Availability = @Availability WHERE DriverID = @DriverID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DriverID", driverId);
                    cmd.Parameters.AddWithValue("@Availability", availability);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Method to delete a driver from the database
        public void DeleteDriver(int driverId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Driver WHERE DriverID = @DriverID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DriverID", driverId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
