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
        public UserBookNowPage3(string carModel, string carNumber, string driverId, string driverName)
        {
            InitializeComponent();

            txt
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Close();
        }

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
    }
}
