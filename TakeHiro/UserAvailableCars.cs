using System.Data;

namespace TakeHiro
{
    public partial class UserAvailableCars : Form
    {
        // DatabaseHelper object to interact with the database.
        private DatabaseHelper _dbHelper;

        // Constructor for UserAvailableCars class.
        public UserAvailableCars()
        {
            InitializeComponent();

            // Initializing DatabaseHelper with connection string.
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            LoadCarData();
            DisplayAvailableCarCount();
        }

        private void LoadCarData()
        {
            try
            {
                // Retrieve available car data from the database and bind it to the DataGridView.
                DataTable carData = _dbHelper.GetAvailableCars();
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
                // Retrieve and display the count of available cars.
                int availableCarCount = _dbHelper.GetAvailabelCarCount();
                lblDriversCount.Text = $"{availableCarCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating available Cars: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserAvailableCars_Load(object sender, EventArgs e){}
        private void lblDriversCount_Click(object sender, EventArgs e){}

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
