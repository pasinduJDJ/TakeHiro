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
    public partial class UserAvailableCars : Form
    {
        private DatabaseHelper _dbHelper;
        public UserAvailableCars()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            LoadCarData();
            DisplayAvailableCarCount();
        }

        private void LoadCarData()
        {
            try
            {
                // Retrieve all car data from the database
                DataTable carData = _dbHelper.GetAvailableCars();

                // Bind car data to DataGridView
                tblCompleteOrder.DataSource = carData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading car data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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

        private void UserAvailableCars_Load(object sender, EventArgs e)
        {

        }

        private void lblDriversCount_Click(object sender, EventArgs e)
        {

        }

        private void btnAvailabelDriver_Click(object sender, EventArgs e)
        {
            UserAvailableDrivers form1 = new UserAvailableDrivers();
            form1.Show();
            this.Hide();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            UserBookNowPage1 form1 = new UserBookNowPage1();
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
