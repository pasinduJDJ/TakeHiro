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
    public partial class AdminHomeDashboard : Form
    {
        // DatabaseHelper object to interact with the database.
        private readonly DatabaseHelper _dbHelper;

        // Constructor for AdminHomeDashboard class.
        public AdminHomeDashboard()
        {
            InitializeComponent();

            // Initializing DatabaseHelper with connection string.
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            LoadDataAndDisplayCounts();
        }

        // Method to load data and display counts of cars, drivers, and orders.
        private void LoadDataAndDisplayCounts()
        {
            try
            {
                LoadCarData();
                LoadDriverData();
                LoadOrderData();
                DisplayCarCount();
                DisplayDriverCount();
                DisplayOrderCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCarData()
        {
            try
            {
                // Retrieve all car data from the database and bind to the data grid.
                DataTable carData = _dbHelper.GetAllCars();
                tblCompleteOrder.DataSource = carData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading car data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void LoadOrderData()
        {
            try
            {
                // Retrieve all order data from the database and bind to the data grid.
                DataTable orderdata = _dbHelper.GetAllOrders();
                tblOrder.DataSource = orderdata;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Order data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Method to display car count statistics.
        private void DisplayCarCount()
        {
            try
            {
                int availableCarCount = _dbHelper.GetAvailabelCarCount();
                lblAvailabelCars.Text = $"{availableCarCount}";
                int allCarCount = _dbHelper.GetCountAllCars();
                lblRegisteredCars.Text = $"{allCarCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available Cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Method to display driver count statistics.
        private void DisplayDriverCount()
        {
            try
            {
                int availableDriverCount = _dbHelper.GetAvailableDriverCount();
                lblAvailabelDrivers.Text = $"{availableDriverCount}";
                int allDriverCount = _dbHelper.GetCountAllDrivers();
                lblRegisteredDrivers.Text = $"{allDriverCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available drivers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Method to display order count statistics.
        private void DisplayOrderCount()
        {
            try
            {
                int orderCount = _dbHelper.GetCountOrders();
                lblOrderCount.Text = $"{orderCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available drivers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e){}

        private void label6_Click(object sender, EventArgs e){}

        private void btnDashBoard_Click(object sender, EventArgs e){}

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            AdminOrderManageDashboard form1 = new AdminOrderManageDashboard();
            form1.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AdminManageDriverDashboard form1 = new AdminManageDriverDashboard();
            form1.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AdminManageCarDashboard form1 = new AdminManageCarDashboard();
            form1.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginPage form1 = new LoginPage();
            form1.Show();
            this.Hide();
        }

        private void tblCompleteOrder_CellContentClick(object sender, DataGridViewCellEventArgs e){}
    }
}
