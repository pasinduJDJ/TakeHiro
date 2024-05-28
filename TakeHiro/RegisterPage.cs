using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TakeHiro
{
    public partial class RegisterPage : Form
    {

        private DatabaseHelper _dbHelper;
        public RegisterPage()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtConatact.Text == "" || txtLocation.Text == "" || txtUser.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string customerName = txtFullName.Text;
                string contactNumber = txtConatact.Text;
                string location = txtLocation.Text;
                string username = txtUser.Text;
                string password = txtPwd.Text;

                try
                {
                    _dbHelper.SaveCustomer(customerName, contactNumber, location, username, password);
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
        }

        private void linkBtnSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage form1 = new LoginPage();
            form1.Show();
            this.Hide();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
