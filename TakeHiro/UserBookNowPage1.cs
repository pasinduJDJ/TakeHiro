using System.Data;

namespace TakeHiro
{
    public partial class UserBookNowPage1 : Form
    {
        // DatabaseHelper object to interact with the database.
        private Driver _driverHelp;

        // Constructor for UserBookNowPage1 class.
        public UserBookNowPage1()
        {
            InitializeComponent();

            // Initializing DatabaseHelper with connection string.
            _driverHelp = new Driver("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            LoadDriverData();
            DisplayAvailableDriverCount();
            InitializeEventHandlers();
        }

        // Event handler for cell click in the DataGridView.
        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblAllDrivers.Rows[e.RowIndex];
                txtDriverID.Text = row.Cells["DriverID"].Value.ToString();
                txtDriverName.Text = row.Cells["Name"].Value.ToString();
                txtContactNumber.Text = row.Cells["ContactNumber"].Value.ToString();
            }
        }

        // Method to display the count of available drivers.
        private void DisplayAvailableDriverCount()
        {
            try
            {
                int availableDriverCount = _driverHelp.GetAvailableDriverCount();
                lblDriversCount.Text = $"{availableDriverCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available drivers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeEventHandlers()
        {
            tblAllDrivers.CellClick += dgvCars_CellClick;
            btnSubDriver.Click += btnPassData_Click;
        }

        // Event handler for passing selected driver data to the next form.
        private void btnPassData_Click(object sender, EventArgs e)
        {
            string driverID = txtDriverID.Text;
            string drivername = txtDriverName.Text;
            string drivernumber = txtContactNumber.Text;

            // Check if driver details are selected before proceeding.
            if (string.IsNullOrEmpty(driverID) || string.IsNullOrEmpty(drivername) || string.IsNullOrEmpty(drivernumber))
            {
                MessageBox.Show("Please select driver before proceeding.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserBookNowPage2 nextForm = new UserBookNowPage2(driverID, drivername, drivernumber);
            nextForm.Show();
            this.Hide();
        }

        private void LoadDriverData()
        {
            try
            {
                // Retrieve available driver data from the database and bind it to the DataGridView.
                DataTable driverData = _driverHelp.GetAvailableDrivers();
                tblAllDrivers.DataSource = driverData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Driver data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserBookNowPage1_Load(object sender, EventArgs e){}

        private void lblDriversCount_Click(object sender, EventArgs e){}

        private void label4_Click(object sender, EventArgs e){}

        private void btnAvailableCar_Click(object sender, EventArgs e)
        {
            UserAvailableCars form1 = new UserAvailableCars();
            form1.Show();
            this.Hide();
        }

        private void btnAvailabelDriver_Click(object sender, EventArgs e)
        {
            UserAvailableDrivers form1 = new UserAvailableDrivers();
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

        private void btnSubDriver_Click(object sender, EventArgs e){}
    }
}
