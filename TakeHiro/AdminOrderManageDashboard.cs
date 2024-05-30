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
        // DatabaseHelper object to interact with the database.
        private DatabaseHelper _dbHelper;
        public AdminOrderManageDashboard()
        {
            InitializeComponent();
            // Initializing DatabaseHelper with connection string.
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Adding items to combo boxes and setting default selection.
            cmdDriverAva.Items.AddRange(new[] { "True", "False" });
            cmdDriverAva.SelectedIndex = 0;

            cmdCarAva.Items.AddRange(new[] { "True", "False" });
            cmdCarAva.SelectedIndex = 0;

            // Setting up event handler for data grid cell click.
            tblOrder.CellClick += tblOrders_CellClick;
            // Loading order data and displaying counts.
            LoadOrderData();
            DisplayCounts();
        }
        // Event handler for data grid cell click.
        private void tblOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblOrder.Rows[e.RowIndex];
                txtCarID.Text = row.Cells["CarID"].Value.ToString();
                txtDriverID.Text = row.Cells["DriverID"].Value.ToString();
            }
        }
        // Method to display counts of cars, drivers, and orders.
        private void DisplayCounts()
        {
            try
            {
                // Retrieve and display counts.
                lblAvailabelCars.Text = $"{_dbHelper.GetAvailabelCarCount()}";
                lblRegisteredCars.Text = $"{_dbHelper.GetCountAllCars()}";
                lblAvailabelDrivers.Text = $"{_dbHelper.GetAvailableDriverCount()}";
                lblRegisteredDrivers.Text = $"{_dbHelper.GetCountAllDrivers()}";
                lblOrderCount.Text = $"{_dbHelper.GetCountOrders()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating counts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Method to load order data from the database.
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

        // Event handler for updating driver availability.
        private void btnDriverAva_Click(object sender, EventArgs e)
        {
            // Validation and updating driver availability.
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
        // Event handler for updating car availability.
        private void btnCarAva_Click(object sender, EventArgs e)
        {
            // Validation and updating car availability.
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
