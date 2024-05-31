using System.Data;

namespace TakeHiro
{
    public partial class UserAvailableDrivers : Form
    {
        // DatabaseHelper object to interact with the database.
        private DatabaseHelper _dbHelper;

        // Constructor for UserAvailableDrivers class.
        public UserAvailableDrivers()
        {
            InitializeComponent();

            // Initializing DatabaseHelper with connection string
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            LoadDriverData();
            DisplayAvailableDriverCount();
        }
        private void LoadDriverData()
        {
            try
            {
                // Retrieve available driver data from the database and bind it to the DataGridView.
                DataTable driverData = _dbHelper.GetAvailableDrivers();
                tblAllDrivers.DataSource = driverData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Driver data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAvailableDriverCount()
        {
            try
            {
                // Retrieve and display the count of available drivers.
                int availableDriverCount = _dbHelper.GetAvailableDriverCount();
                lblDriversCount.Text = $"{availableDriverCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available drivers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            UserBookNowPage1 form1 = new UserBookNowPage1();
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
    }
}
