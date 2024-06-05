using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TakeHiro
{
    public partial class AdminManageCarDashboard : Form
    {
        // DatabaseHelper object to interact with the database.
        private Car _carHelper;

        public AdminManageCarDashboard()
        {
            InitializeComponent();
            // Initializing DatabaseHelper with connection string.
            _carHelper = new Car("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");
            InitializeComponents();
            LoadCarData();
            DisplayCarCount();
        }

        private void InitializeComponents()
        {
            // Adding items to availability combo box and setting default selection.
            cmbAvailability.Items.AddRange(new object[] { "True", "False" });
            cmbAvailability.SelectedIndex = 0;
            // Setting up event handlers for data grid cell click and button clicks.
            tblAllDrivers.CellClick += tblAllDrivers_CellClick;
            btnSubmitChnages.Click += btnSubmitChanges_Click;
            btnRemoveCar.Click += btnDeleteCar_Click;
            btnAddNewCar.Click += btnAddNewCar_Click;
            btnClear.Click += btnClear_Click;
        }

        private void LoadCarData()
        {
            if (tblAllDrivers == null)
            {
                MessageBox.Show("Data grid view is not initialized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Retrieve all Car data from the database and bind to the data grid.
                DataTable carData = _carHelper.GetAllCars();
                tblAllDrivers.DataSource = carData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading car data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for adding a new Car.
        private void btnAddNewCar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarModel.Text) || string.IsNullOrWhiteSpace(txtCarNumber.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string plateNumber = txtCarNumber.Text;
            string pattern = @"^[A-Z]{3} \d{4}$";
            bool isValidPlateNumber = Regex.IsMatch(plateNumber, pattern);

            if (!isValidPlateNumber)
            {
                MessageBox.Show("Please enter a valid vehicle number plate (format: ABC 1234)", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool availability = cmbAvailability.SelectedItem.ToString() == "True";

            Car newCar = new Car(_carHelper.GetConnection().ConnectionString)
            {
                Model = txtCarModel.Text,
                PlateNumber = plateNumber,
                Availability = availability
            };

            try
            {
                // Save the new driver to the database.
                newCar.SaveCar();
                MessageBox.Show("New car added successfully.");
                ClearInputs();
                LoadCarData();
                DisplayCarCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblAllDrivers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblAllDrivers.Rows[e.RowIndex];
                lblCarID.Text = row.Cells["CarID"].Value.ToString();
                txtCarModel.Text = row.Cells["Model"].Value.ToString();
                txtCarNumber.Text = row.Cells["PlateNumber"].Value.ToString();
                cmbAvailability.SelectedItem = row.Cells["Availability"].Value.ToString() == "True" ? "True" : "False";
            }
        }

        private void btnSubmitChanges_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCarID.Text) || string.IsNullOrWhiteSpace(txtCarModel.Text) || string.IsNullOrWhiteSpace(txtCarNumber.Text))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int carId = int.Parse(lblCarID.Text);
            string model = txtCarModel.Text;
            string plateNumber = txtCarNumber.Text;
            string pattern = @"^[A-Z]{3} \d{4}$";
            bool isValidPlateNumber = Regex.IsMatch(plateNumber, pattern);

            if (!isValidPlateNumber)
            {
                MessageBox.Show("Please enter a valid vehicle number plate (format: ABC 1234)", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool availability = cmbAvailability.SelectedItem.ToString() == "True";
            Car newCar = new Car(_carHelper.GetConnection().ConnectionString)
            {
                CarID = carId,
                Model = txtCarModel.Text,
                PlateNumber = plateNumber,
                Availability = availability
            };
            try
            {
                newCar.UpdateCar();
                MessageBox.Show("Car details updated successfully.");
                ClearInputs();
                LoadCarData();
                DisplayCarCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCarID.Text))
            {
                MessageBox.Show("Please select a car to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int carId = int.Parse(lblCarID.Text);

            try
            {
                _carHelper.DeleteCar(carId);
                MessageBox.Show("Car deleted successfully.");
                ClearInputs();
                LoadCarData();
                DisplayCarCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Method to display Car count statistics.
        private void DisplayCarCount()
        {
            try
            {
                int availableCarCount = _carHelper.GetAvailabelCarCount();
                lblAvaCars.Text = $"{availableCarCount}";
                int allCarCount = _carHelper.GetCountAllCars();
                lblRegCars.Text = $"{allCarCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtCarModel.Clear();
            txtCarNumber.Clear();
            cmbAvailability.SelectedIndex = 0;
            lblCarID.Text = "000";
        }

        private void btnDashBoard_Click(object? sender, EventArgs e)
        {
            AdminHomeDashboard form1 = new AdminHomeDashboard();
            form1.Show();
            this.Hide();
        }

        private void btnManageOrders_Click(object? sender, EventArgs e)
        {
            AdminOrderManageDashboard form1 = new AdminOrderManageDashboard();
            form1.Show();
            this.Hide();
        }

        private void iconButton1_Click(object? sender, EventArgs e)
        {
            AdminManageDriverDashboard form1 = new AdminManageDriverDashboard();
            form1.Show();
            this.Hide();
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object? sender, EventArgs e)
        {
            LoginPage form1 = new LoginPage();
            form1.Show();
            this.Hide();
        }
    }
}
