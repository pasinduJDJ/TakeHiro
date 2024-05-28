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
        private DatabaseHelper _dbHelper;
        public AdminHomeDashboard()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            LoadCarData();
            LoadDriverData();
            LoadOrderData();
        }

        private void LoadCarData()
        {
            try
            {
                // Retrieve all car data from the database
                DataTable carData = _dbHelper.GetAllCars();

                // Bind car data to DataGridView
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
        private void LoadOrderData()
        {
            try
            {
                // Retrieve all Driver data from the database
                DataTable orderdata = _dbHelper.GetAllOrders();

                // Bind Driver data to DataGridView
                tblOrder.DataSource = orderdata;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Order data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {

        }

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

        private void tblCompleteOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
