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



        // Save Database 
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
                cmd.Parameters.AddWithValue("@OrderDate", orderDate); 

                cmd.ExecuteNonQuery();
            }
        }



        // Retrieve Database all data
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



        // Retrive Avilabel Data
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



        // Count Availabel Data
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



        // Count all Data 
        public int GetCountAllDrivers()
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Driver";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return count;
        }
        public int GetCountAllCars()
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Car";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return count;
        }
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




        // Validate Customers 
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



        //Update Data using ID  
        public void UpdateCar(int carId, string model, string plateNumber, bool availability)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Car SET Model = @Model, PlateNumber = @PlateNumber, Availability = @Availability WHERE CarID = @CarID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CarID", carId);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                cmd.Parameters.AddWithValue("@Availability", availability);

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateCar(int carId, bool availability)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Car SET Availability = @Availability WHERE CarID = @CarID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CarID", carId);
                cmd.Parameters.AddWithValue("@Availability", availability);

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateDriver(int driverId, string name, string contactNumber, bool availability)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Driver SET Name = @Name, ContactNumber = @ContactNumber, Availability = @Availability WHERE DriverID = @DriverID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", driverId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@Availability", availability);

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateDriver(int driverId, bool availability)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Driver SET Availability = @Availability WHERE DriverID = @DriverID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", driverId);
                cmd.Parameters.AddWithValue("@Availability", availability);

                cmd.ExecuteNonQuery();
            }
        }






        // Delete Data Using ID 
        public void DeleteCar(int carId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Car WHERE CarID = @CarID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CarID", carId);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteDriver(int driverId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Driver WHERE DriverID = @DriverID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", driverId);
                cmd.ExecuteNonQuery();
            }
        }



    }
}
