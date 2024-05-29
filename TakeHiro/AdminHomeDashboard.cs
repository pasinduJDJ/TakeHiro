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

            DisplayCarCount();
            DisplayDriverCount();
            DisplayOrderCount();
        }

        private void LoadCarData()
        {
            try
            {
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
                DataTable orderdata = _dbHelper.GetAllOrders();
                tblOrder.DataSource = orderdata;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Order data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
