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

            // Initialize ComboBox items
            cmbAvailability.Items.Add("True");
            cmbAvailability.Items.Add("False");
            cmbAvailability.SelectedIndex = 0;
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
    }
}
