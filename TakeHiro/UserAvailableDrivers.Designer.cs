﻿namespace TakeHiro
{
    partial class UserAvailableDrivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAvailableDrivers));
            panel1 = new Panel();
            btnAvailableCar = new FontAwesome.Sharp.IconButton();
            btnAvailabelDriver = new FontAwesome.Sharp.IconButton();
            btnBookNow = new FontAwesome.Sharp.IconButton();
            btnClose = new Button();
            btnLogOut = new Button();
            imgUser = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tblAllDrivers = new DataGridView();
            label1 = new Label();
            panel3 = new Panel();
            lblDriversCount = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 46, 52);
            panel1.Controls.Add(btnAvailableCar);
            panel1.Controls.Add(btnAvailabelDriver);
            panel1.Controls.Add(btnBookNow);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnLogOut);
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 479);
            panel1.TabIndex = 2;
            // 
            // btnAvailableCar
            // 
            btnAvailableCar.FlatAppearance.BorderSize = 0;
            btnAvailableCar.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 12, 12);
            btnAvailableCar.FlatStyle = FlatStyle.Flat;
            btnAvailableCar.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvailableCar.ForeColor = Color.White;
            btnAvailableCar.IconChar = FontAwesome.Sharp.IconChar.AnglesRight;
            btnAvailableCar.IconColor = Color.White;
            btnAvailableCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAvailableCar.IconSize = 20;
            btnAvailableCar.ImageAlign = ContentAlignment.MiddleRight;
            btnAvailableCar.Location = new Point(-1, 137);
            btnAvailableCar.Margin = new Padding(0, 0, 10, 0);
            btnAvailableCar.Name = "btnAvailableCar";
            btnAvailableCar.Padding = new Padding(0, 0, 10, 0);
            btnAvailableCar.Size = new Size(206, 54);
            btnAvailableCar.TabIndex = 8;
            btnAvailableCar.Text = "Cars";
            btnAvailableCar.UseVisualStyleBackColor = true;
            btnAvailableCar.Click += btnAvailableCar_Click;
            // 
            // btnAvailabelDriver
            // 
            btnAvailabelDriver.BackColor = Color.Black;
            btnAvailabelDriver.FlatAppearance.BorderSize = 0;
            btnAvailabelDriver.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 12, 12);
            btnAvailabelDriver.FlatStyle = FlatStyle.Flat;
            btnAvailabelDriver.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvailabelDriver.ForeColor = Color.White;
            btnAvailabelDriver.IconChar = FontAwesome.Sharp.IconChar.AnglesRight;
            btnAvailabelDriver.IconColor = Color.White;
            btnAvailabelDriver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAvailabelDriver.IconSize = 20;
            btnAvailabelDriver.ImageAlign = ContentAlignment.MiddleRight;
            btnAvailabelDriver.Location = new Point(0, 83);
            btnAvailabelDriver.Margin = new Padding(0, 0, 10, 0);
            btnAvailabelDriver.Name = "btnAvailabelDriver";
            btnAvailabelDriver.Padding = new Padding(0, 0, 10, 0);
            btnAvailabelDriver.Size = new Size(206, 54);
            btnAvailabelDriver.TabIndex = 7;
            btnAvailabelDriver.Text = "Drivers";
            btnAvailabelDriver.UseVisualStyleBackColor = false;
            // 
            // btnBookNow
            // 
            btnBookNow.FlatAppearance.BorderSize = 0;
            btnBookNow.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 12, 12);
            btnBookNow.FlatStyle = FlatStyle.Flat;
            btnBookNow.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookNow.ForeColor = Color.White;
            btnBookNow.IconChar = FontAwesome.Sharp.IconChar.AnglesRight;
            btnBookNow.IconColor = Color.White;
            btnBookNow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBookNow.IconSize = 20;
            btnBookNow.ImageAlign = ContentAlignment.MiddleRight;
            btnBookNow.Location = new Point(0, 29);
            btnBookNow.Margin = new Padding(0, 0, 10, 0);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Padding = new Padding(0, 0, 10, 0);
            btnBookNow.Size = new Size(206, 54);
            btnBookNow.TabIndex = 2;
            btnBookNow.Text = "Book Now";
            btnBookNow.UseVisualStyleBackColor = true;
            btnBookNow.Click += btnBookNow_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(233, 234, 236);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(22, 389);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(166, 35);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(228, 182, 26);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(22, 430);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(166, 35);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out ";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // imgUser
            // 
            imgUser.Image = (Image)resources.GetObject("imgUser.Image");
            imgUser.Location = new Point(906, 14);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(30, 30);
            imgUser.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUser.TabIndex = 1;
            imgUser.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 46, 52);
            panel2.Controls.Add(imgUser);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 65);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 200);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 9;
            label2.Text = "TakeHiro Our Drivers";
            // 
            // tblAllDrivers
            // 
            tblAllDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblAllDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAllDrivers.Location = new Point(240, 241);
            tblAllDrivers.Name = "tblAllDrivers";
            tblAllDrivers.RowHeadersWidth = 51;
            tblAllDrivers.Size = new Size(678, 276);
            tblAllDrivers.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 0;
            label1.Text = "Drivers ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(228, 182, 26);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblDriversCount);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(240, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 88);
            panel3.TabIndex = 10;
            // 
            // lblDriversCount
            // 
            lblDriversCount.AutoSize = true;
            lblDriversCount.Font = new Font("Nirmala UI", 22F, FontStyle.Bold);
            lblDriversCount.ForeColor = Color.Black;
            lblDriversCount.Location = new Point(161, 25);
            lblDriversCount.Name = "lblDriversCount";
            lblDriversCount.Size = new Size(64, 50);
            lblDriversCount.TabIndex = 8;
            lblDriversCount.Text = "31";
            // 
            // UserAvailableDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(label2);
            Controls.Add(tblAllDrivers);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAvailableDrivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserBookNowPage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAvailableCar;
        private FontAwesome.Sharp.IconButton btnAvailabelDriver;
        private FontAwesome.Sharp.IconButton btnBookNow;
        private Button btnClose;
        private Button btnLogOut;
        private PictureBox imgUser;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private DataGridView tblAllDrivers;
        private Label label1;
        private Panel panel3;
        private Label lblDriversCount;
    }
}