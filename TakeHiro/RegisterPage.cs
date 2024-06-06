namespace TakeHiro
{
    public partial class RegisterPage : Form
    {
        // DatabaseHelper object to interact with the database.
        private Customers _customerHelp;

        // Constructor for RegisterPage class.
        public RegisterPage()
        {
            InitializeComponent();

            // Initializing DatabaseHelper with connection string.
            _customerHelp = new Customers("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled.
            if (txtFullName.Text == "" || txtConatact.Text == "" || txtLocation.Text == "" || txtUser.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string customerName = txtFullName.Text;
            string contactNumber = txtConatact.Text;
            string location = txtLocation.Text;
            string username = txtUser.Text;
            string password = txtPwd.Text;
            Customers newCus = new Customers(_customerHelp.GetConnection().ConnectionString)
            {
                CustomerName = customerName,
                CustomerNumber = contactNumber,
                Location = location,
                Username = username,
                password = password
            };
            try
            {
                newCus.SaveCustomer();
                MessageBox.Show("Customer signed up successfully.");
                LoginPage form1 = new LoginPage();
                form1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void linkBtnSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage form1 = new LoginPage();
            form1.Show();
            this.Hide();
        }
        private void RegisterPage_Load(object sender, EventArgs e){}
        private void btnColse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
