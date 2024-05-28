﻿using System;
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
    public partial class UserBookNowPage1 : Form
    {
        private DatabaseHelper _dbHelper;
        public UserBookNowPage1()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper("Server=localhost;Database=cabManagementdb;User ID=root;Password=root;SslMode=none;");

            LoadDriverData();

            tblAllDrivers.CellClick += new DataGridViewCellEventHandler(dgvCars_CellClick);
            btnSubDriver.Click += new EventHandler(btnPassData_Click);
        }
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
        private void btnPassData_Click(object sender, EventArgs e)
        {
            string driverID = txtDriverID.Text;
            string drivername = txtDriverName.Text;
            string drivernumber = txtContactNumber.Text;

            UserBookNowPage2 nextForm = new UserBookNowPage2(driverID, drivername, drivernumber);
            nextForm.Show();
            this.Hide();
        }

        private void LoadDriverData()
        {
            try
            {
                DataTable driverData = _dbHelper.GetAllDrivers();
                tblAllDrivers.DataSource = driverData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Driver data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserBookNowPage1_Load(object sender, EventArgs e)
        {

        }

        private void lblDriversCount_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

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

        private void btnSubDriver_Click(object sender, EventArgs e)
        {

        }
    }
}
