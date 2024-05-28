using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private DatabaseHelper _dbHelper;
        public UserBookNowPage2(string driverID, string driverName)
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            LoadCarData();

            lblDriverID.Text = driverID;
            lblDriverName.Text = driverName;    

            tblAllDrivers.CellClick += new DataGridViewCellEventHandler(dgvCars_CellClick);
            btnSubCar.Click += new EventHandler(btnPassData_Click);
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
        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblAllDrivers.Rows[e.RowIndex];
                txtCarModel.Text = row.Cells["Model"].Value.ToString();
                txtPlateNumber.Text = row.Cells["PlateNumber"].Value.ToString();
            }
        }
        private void btnPassData_Click(object sender, EventArgs e)
        {
            string carModel = txtCarModel.Text;
            string carNumber = txtPlateNumber.Text;
            string driverId = lblDriverID.Text;
            string driverName=lblDriverName.Text;

            UserBookNowPage3 nextForm = new UserBookNowPage3(carModel, carNumber, driverId, driverName);
            nextForm.Show();
            this.Hide();
        }


        private void tblAllDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
