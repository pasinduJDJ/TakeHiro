using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            LoadCarData();

            // Initialize ComboBox items
            cmbAvailability.Items.Add("True");
            cmbAvailability.Items.Add("False");
            cmbAvailability.SelectedIndex = 0;
        }
        private void LoadCarData()
        {
            try
            {
                // Retrieve all car data from the database
                DataTable carData = _dbHelper.GetAllCars();

                // Bind car data to DataGridView
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
                bool availability = cmbAvailability.SelectedItem.ToString() == "True";

                try
                {
                    _dbHelper.SaveCar(model, plateNumber, availability);
                    MessageBox.Show("Car Added successfully.");
                    txtCarModel.Clear();
                    txtCarNumber.Clear();
                    cmbAvailability.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblAllDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
