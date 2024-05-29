using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHiro
{
    public partial class AdminManageDriverDashboard : Form
    {
        private DatabaseHelper _dbHelper;
        public AdminManageDriverDashboard()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");


            LoadDriverData();
            // Initialize ComboBox items
            cmbAvailability.Items.Add("True");
            cmbAvailability.Items.Add("False");
            cmbAvailability.SelectedIndex = 0;

            DisplayDriverCount();
        }

        private void LoadDriverData()
        {
            try
            {
                // Retrieve all Driver data from the database
                DataTable driverData = _dbHelper.GetAllDrivers();

                // Bind Driver data to DataGridView
                tblAllDrivers.DataSource = driverData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Driver data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                bool availability = cmbAvailability.SelectedItem.ToString() == "True";

                try
                {
                    _dbHelper.SaveDriver(name, contactNumber, availability);
                    MessageBox.Show("Car Added successfully.");
                    txtContactNumber.Clear();
                    txtDriverName.Clear();
                    cmbAvailability.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void DisplayDriverCount()
        {
            try
            {
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

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

        private void btnSubmitChnages_Click(object sender, EventArgs e)
        {

        }
    }
}
