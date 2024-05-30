using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TakeHiro
{
    public partial class AdminManageCarDashboard : Form
    {
        private DatabaseHelper _dbHelper;
        public AdminManageCarDashboard()
        {
            InitializeComponent();

            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");


            InitializeComponents();
            LoadCarData();
            DisplayCarCount();
        }
        private void InitializeComponents()
        {
            cmbAvailability.Items.AddRange(new object[] { true, false });
            cmbAvailability.SelectedIndex = 0;

            tblAllDrivers.CellClick += tblAllDrivers_CellClick;
            btnSubmitChnages.Click += btnSubmitChanges_Click;
            btnRemoveCar.Click += btnDeleteCar_Click;
        }

        private void ClearInputs()
        {
            txtCarModel.Clear();
            txtCarNumber.Clear();
            cmbAvailability.SelectedIndex = 0;
            lblCarID.Text = "000";
        }


        private void LoadCarData()
        {
            try
            {
                DataTable carData = _dbHelper.GetAllCars();
                tblAllDrivers.DataSource = carData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading car data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            if (txtCarModel.Text == "" || txtCarNumber.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string model = txtCarModel.Text;
                string plateNumber = txtCarNumber.Text;

                // Regular expression for validating vehicle number plates with the format: ABC 1234
                string pattern = @"^[A-Z]{3} \d{4}$";
                bool isValidPlateNumber = Regex.IsMatch(plateNumber, pattern);

                if (!isValidPlateNumber)
                {
                    MessageBox.Show("Please enter a valid vehicle number plate (format: ABC 1234)", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if the vehicle number plate is invalid
                }

                bool availability = cmbAvailability.SelectedItem.ToString() == "True";

                try
                {
                    _dbHelper.SaveCar(model, plateNumber, availability);
                    MessageBox.Show("Car Added successfully.");
                    ClearInputs();
                    LoadCarData();
                    DisplayCarCount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private void tblAllDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
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
        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            if (lblCarID.Text == "" || txtCarModel.Text == "" || txtCarNumber.Text == "")
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int carId = int.Parse(lblCarID.Text);
            string model = txtCarModel.Text;
            string plateNumber = txtCarNumber.Text;
            bool availability = cmbAvailability.SelectedItem.ToString() == "True";

            try
            {
                _dbHelper.UpdateCar(carId, model, plateNumber, availability);
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

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (lblCarID.Text == "")
            {
                MessageBox.Show("Please select a car to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int carId = int.Parse(lblCarID.Text);

            try
            {
                _dbHelper.DeleteCar(carId);
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

        private void DisplayCarCount()
        {
            try
            {
                int availableCarCount = _dbHelper.GetAvailabelCarCount();
                lblAvaCars.Text = $"{availableCarCount}";
                int allCarCount = _dbHelper.GetCountAllCars();
                lblRegCars.Text = $"{allCarCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available Cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel3_Paint(object sender, PaintEventArgs e){}

        private void tblAllDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e){}

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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AdminManageDriverDashboard form1 = new AdminManageDriverDashboard();
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

        private void btnSubmitChnages_Click(object sender, EventArgs e){}

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
