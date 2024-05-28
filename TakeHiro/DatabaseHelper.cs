﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
