using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHiro
{
    public partial class UserBookNowPage2 : Form
    {
        // DatabaseHelper object to interact with the database.
        private readonly DatabaseHelper _dbHelper;

        // Stores the selected driver's ID.
        private readonly string _driverId;

        public UserBookNowPage2(string driverID, string driverName, string drivernumber)
        {
            InitializeComponent();

            // Initializing DatabaseHelper with connection string.
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");
            _driverId = driverID;

            // Display driver information on the labels.
            lblDriverTp.Text = drivernumber;
            lblDriverName.Text = driverName;

            InitializeEventHandlers();

            LoadCarData();
            DisplayAvailableCarCount();
        }

        // Property to get the Driver ID.
        public string DriverId
        {
            get { return _driverId; }
        }

        // Method to load available car data from the database.
        private void LoadCarData()
        {
            try
            {
                // Retrieve available car data from the database and bind it to the DataGridView.
                DataTable carData = _dbHelper.GetAvailableCars();
                tblAllDrivers.DataSource = carData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading car data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for cell click in the DataGridView.
        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblAllDrivers.Rows[e.RowIndex];
                txtCarModel.Text = row.Cells["Model"].Value.ToString();
                txtPlateNumber.Text = row.Cells["PlateNumber"].Value.ToString();
                lblNewCarId.Text = row.Cells["CarID"].Value.ToString();
            }
        }
        private void InitializeEventHandlers()
        {
            tblAllDrivers.CellClick += dgvCars_CellClick;
            btnSubCar.Click += btnPassData_Click;
        }

        // Method to display the count of available cars.
        private void DisplayAvailableCarCount()
        {
            try
            {
                int availableCarCount = _dbHelper.GetAvailabelCarCount();
                lblDriversCount.Text = $"{availableCarCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available Cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for passing selected car data to the next form.
        private void btnPassData_Click(object sender, EventArgs e)
        {
            string carModel = txtCarModel.Text;
            string carNumber = txtPlateNumber.Text;
            string driverTp = lblDriverTp.Text;
            string driverName = lblDriverName.Text;
            string carId = lblNewCarId.Text;

            // Check if car details are selected before proceeding.
            if (string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(carNumber) || string.IsNullOrEmpty(carId))
            {
                MessageBox.Show("Please select car before proceeding.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserBookNowPage3 nextForm = new UserBookNowPage3(carModel, carNumber, carId, _driverId, driverName, driverTp);
            nextForm.Show();
            this.Hide();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            UserBookNowPage1 form1 = new UserBookNowPage1();
            form1.Show();
            this.Hide();
        }

        private void btnAvailabelDriver_Click(object sender, EventArgs e)
        {
            UserAvailableDrivers form1 = new UserAvailableDrivers();
            form1.Show();
            this.Hide();
        }

        private void btnAvailableCar_Click(object sender, EventArgs e)
        {
            UserAvailableCars form1 = new UserAvailableCars();
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



        private void tblAllDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void btnSubCar_Click(object sender, EventArgs e){}
    }
}
