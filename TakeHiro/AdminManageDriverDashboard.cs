﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHiro
{
    public partial class AdminManageDriverDashboard : Form
    {
        // DatabaseHelper object to interact with the database.
        private DatabaseHelper _dbHelper;

        public AdminManageDriverDashboard()
        {
            InitializeComponent();
            // Initializing DatabaseHelper with connection string.
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            InitializeComponents();
            LoadDriverData();
            DisplayDriverCount();
        }

        private void InitializeComponents()
        {
            // Adding items to availability combo box and setting default selection.
            cmbAvailability.Items.AddRange(new object[] { true, false });
            cmbAvailability.SelectedIndex = 0;
            // Setting up event handlers for data grid cell click and button clicks.
            tblAllDrivers.CellClick += tblAllDrivers_CellClick;
            btnSubmitChnages.Click += btnSubmitChanges_Click;
            btnRemoveDriver.Click += btnDeleteDriver_Click;
        }

        private void LoadDriverData()
        {
            try
            {
                // Retrieve all driver data from the database and bind to the data grid.
                DataTable driverData = _dbHelper.GetAllDrivers();
                tblAllDrivers.DataSource = driverData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Driver data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for adding a new driver.
        private void btnAddNewDriver_Click(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "" || txtDriverName.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtDriverName.Text;
                string contactNumber = txtContactNumber.Text;

                // Regular expression for validating mobile number 
                string pattern = @"^[7-9]\d{9}$";
                bool isValidMobile = Regex.IsMatch(contactNumber, pattern);

                if (!isValidMobile)
                {
                    MessageBox.Show("Please enter a valid mobile number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                bool availability = cmbAvailability.SelectedItem.ToString() == "True";

                try
                {
                    // Save the new driver to the database.
                    _dbHelper.SaveDriver(name, contactNumber, availability);
                    MessageBox.Show("Car Added successfully.");
                    ClearInputs();
                    LoadDriverData();
                    DisplayDriverCount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        // Method to display driver count statistics.
        private void DisplayDriverCount()
        {
            try
            {
                // Retrieve and display the count of available and all drivers.
                int availableDriverCount = _dbHelper.GetAvailableDriverCount();
                lblAvgDriver.Text = $"{availableDriverCount}";
                int allDriverCount = _dbHelper.GetCountAllDrivers();
                lblRegDriver.Text = $"{allDriverCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available drivers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Event handler for data grid cell click.
        private void tblAllDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Load the selected driver's details into the input fields.
                DataGridViewRow row = tblAllDrivers.Rows[e.RowIndex];
                lblDriverID.Text = row.Cells["DriverID"].Value.ToString();
                txtDriverName.Text = row.Cells["Name"].Value.ToString();
                txtContactNumber.Text = row.Cells["ContactNumber"].Value.ToString();
                cmbAvailability.SelectedItem = row.Cells["Availability"].Value.ToString() == "True" ? "True" : "False";
            }
        }
        // Event handler for submitting changes to a driver.
        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            if (lblDriverID.Text == "" || txtDriverName.Text == "" || txtContactNumber.Text == "")
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int driverId = int.Parse(lblDriverID.Text);
            string name = txtDriverName.Text;
            string contactNumber = txtContactNumber.Text;
            bool availability = cmbAvailability.SelectedItem.ToString() == "True";

            try
            {
                // Update the driver details in the database.
                _dbHelper.UpdateDriver(driverId, name, contactNumber, availability);
                MessageBox.Show("Car details updated successfully.");
                ClearInputs();
                LoadDriverData();
                DisplayDriverCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Event handler for deleting a driver.
        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (lblDriverID.Text == "")
            {
                MessageBox.Show("Please select a driver to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int driverId = int.Parse(lblDriverID.Text);

            try
            {
                _dbHelper.DeleteDriver(driverId);
                MessageBox.Show("Car deleted successfully.");
                ClearInputs();
                LoadDriverData();
                DisplayDriverCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminHomeDashboard form1 = new AdminHomeDashboard();
            form1.Show();
            this.Hide();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            AdminOrderManageDashboard form1 = new AdminOrderManageDashboard();
            form1.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AdminManageCarDashboard form1 = new AdminManageCarDashboard();
            form1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e){}

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginPage form1 = new LoginPage();
            form1.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmitChnages_Click(object sender, EventArgs e){}

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void ClearInputs()
        {
            txtDriverName.Clear();
            txtContactNumber.Clear();
            cmbAvailability.SelectedIndex = 0;
            lblDriverID.Text = "000";
        }
    }
}
