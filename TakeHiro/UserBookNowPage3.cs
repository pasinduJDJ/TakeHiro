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
    public partial class UserBookNowPage3 : Form
    {
        // DatabaseHelper object to interact with the database.
        private readonly DatabaseHelper _dbHelper;

        // Stores the selected car and driver IDs.
        private readonly string _carId;
        private readonly string _driverId;
        public UserBookNowPage3(string carModel, string carNumber, string carId, string driverId, string driverName, string driverTp)
        {
            InitializeComponent();

            // Initializing DatabaseHelper with connection string
            _dbHelper = new DatabaseHelper("Server=localhost;Database=CabManagementDB;User ID=root;Password=root;SslMode=none;");

            _carId = carId;
            _driverId = driverId;

            SetDataInLabel(carModel, carNumber, driverName, driverTp);
        }
        // Property to get the Car ID.
        public string CarId
        {
            get { return _carId; }
        }
        // Property to get the Driver ID.
        public string DriverId
        {
            get { return _driverId; }
        }

        // Method to set car and driver data in the respective labels.
        private void SetDataInLabel(string carModel, string carNumber, string driverName, string driverTp)
        {
            lblCarModel.Text = carModel;
            lblCarNumber.Text = carNumber;
            lblDriverName.Text = driverName;
            lblContactNumber.Text = driverTp;
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

        private void panel1_Paint(object sender, PaintEventArgs e){}

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

        private void label10_Click(object sender, EventArgs e){}

        private void label5_Click(object sender, EventArgs e){}

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Check if destination and location fields are filled.
            if (txtDestination.Text == "" || txtLocation.Text=="")
            {
                MessageBox.Show("Please enter destination and  location before processing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string customerName = "3"; 
                string driverID = _driverId;
                string carID = _carId;
                string destination = txtDestination.Text;
                string location = txtLocation.Text;
                string orderDate = DateTime.Now.ToString("yyyy-MM-dd"); 

                try
                {
                    // Save order to the database.
                    _dbHelper.SaveOrder(customerName, driverID, carID, destination, location, orderDate);
                    MessageBox.Show("Order signed up successfully.");
                    UserBookNowPage1 form1 = new UserBookNowPage1();
                    form1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            UserBookNowPage1 form1 = new UserBookNowPage1();
            form1.Show();
            this.Hide();
        }
    }
}
