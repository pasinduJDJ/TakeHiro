namespace TakeHiro
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

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
