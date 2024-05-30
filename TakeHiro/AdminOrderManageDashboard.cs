using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TakeHiro
{
    public partial class AdminOrderManageDashboard : Form
    {
        private DatabaseHelper _dbHelper;
        public AdminOrderManageDashboard()
        {
            InitializeComponent();

            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            cmdDriverAva.Items.Add("True");
            cmdDriverAva.Items.Add("False");
            cmdDriverAva.SelectedIndex = 0;
            
            cmdCarAva.Items.Add("True");
            cmdCarAva.Items.Add("False");
            cmdCarAva.SelectedIndex = 0;

            LoadOrderData();
            DisplayCarCount();
            DisplayDriverCount();
            DisplayOrderCount();
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

        private void label5_Click(object sender, EventArgs e){}

        private void panel4_Paint(object sender, PaintEventArgs e){}

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminHomeDashboard form1 = new AdminHomeDashboard();
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

        private void btnDriverAva_Click(object sender, EventArgs e)
        {
            if (txtDriverID.Text == "")
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int driverID = int.Parse(txtDriverID.Text);
            bool availability = cmdDriverAva.SelectedItem.ToString() == "True";

            try
            {
                _dbHelper.UpdateDriver(driverID, availability);
                MessageBox.Show("Driver Availability updated successfully.");
                txtDriverID.Clear();
                cmdDriverAva.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnCarAva_Click(object sender, EventArgs e)
        {
            if (txtCarID.Text == "")
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int carID = int.Parse(txtCarID.Text);
            bool availability = cmdCarAva.SelectedItem.ToString() == "True";

            try
            {
                _dbHelper.UpdateCar(carID, availability);
                MessageBox.Show("Driver Availability updated successfully.");
                txtCarID.Clear();
                cmdCarAva.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
