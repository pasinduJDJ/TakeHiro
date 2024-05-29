namespace TakeHiro
{
    public partial class LoginPage : Form
    {
        
        private DatabaseHelper _dbHelper;
        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin123";
        public LoginPage()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");
        }

        private void label1_Click(object sender, EventArgs e){}

        private void label1_Click_1(object sender, EventArgs e){}

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void LoginPage_Load(object sender, EventArgs e){}

        private void txtPwd_TextChanged(object sender, EventArgs e){}

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string password = txtPwd.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (username == AdminUsername && password == AdminPassword)
            {
                AdminHomeDashboard adminDashboard = new AdminHomeDashboard();
                adminDashboard.Show();
                this.Hide();
            }
            else
            {
                int? customerId = _dbHelper.ValidateCustomerLogin(username, password);
                if (customerId.HasValue)
                {
                    UserBookNowPage1 customerPage = new UserBookNowPage1();
                    customerPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtbtnSignUp_Click(object sender, EventArgs e)
        {
            RegisterPage Fomr1 = new RegisterPage();
            Fomr1.Show();
            this.Hide();
        }

        private void linkBtnSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage Fomr1 = new RegisterPage();
            Fomr1.Show();
            this.Hide();
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
