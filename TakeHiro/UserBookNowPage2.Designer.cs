namespace TakeHiro
{
    partial class UserBookNowPage2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBookNowPage2));
            panel4 = new Panel();
            btnSubCar = new Button();
            txtPlateNumber = new TextBox();
            label5 = new Label();
            txtCarModel = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblDriversCount = new Label();
            label1 = new Label();
            label2 = new Label();
            tblAllDrivers = new DataGridView();
            panel1 = new Panel();
            btnAvailableCar = new FontAwesome.Sharp.IconButton();
            btnAvailabelDriver = new FontAwesome.Sharp.IconButton();
            btnBookNow = new FontAwesome.Sharp.IconButton();
            btnClose = new Button();
            btnLogOut = new Button();
            pictureBox1 = new PictureBox();
            lblUserID = new Label();
            imgUser = new PictureBox();
            panel2 = new Panel();
            label6 = new Label();
            label7 = new Label();
            lblDriverID = new Label();
            lblDriverName = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblDriverName);
            panel4.Controls.Add(lblDriverID);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(btnSubCar);
            panel4.Controls.Add(txtPlateNumber);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtCarModel);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.ImeMode = ImeMode.Off;
            panel4.Location = new Point(667, 218);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 301);
            panel4.TabIndex = 14;
            // 
            // btnSubCar
            // 
            btnSubCar.BackColor = Color.FromArgb(42, 46, 52);
            btnSubCar.FlatAppearance.BorderSize = 0;
            btnSubCar.FlatStyle = FlatStyle.Flat;
            btnSubCar.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubCar.ForeColor = Color.White;
            btnSubCar.Location = new Point(16, 245);
            btnSubCar.Margin = new Padding(0);
            btnSubCar.Name = "btnSubCar";
            btnSubCar.Size = new Size(222, 37);
            btnSubCar.TabIndex = 5;
            btnSubCar.Text = "Destination";
            btnSubCar.UseVisualStyleBackColor = false;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPlateNumber.Location = new Point(16, 197);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(222, 27);
            txtPlateNumber.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 8F);
            label5.Location = new Point(16, 174);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 3;
            label5.Text = "Car Number";
            // 
            // txtCarModel
            // 
            txtCarModel.BorderStyle = BorderStyle.FixedSingle;
            txtCarModel.Location = new Point(16, 133);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(222, 27);
            txtCarModel.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 8F);
            label4.Location = new Point(16, 110);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 1;
            label4.Text = "Car Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 11);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 0;
            label3.Text = "Select Car Details";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(228, 182, 26);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblDriversCount);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(663, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 65);
            panel3.TabIndex = 13;
            // 
            // lblDriversCount
            // 
            lblDriversCount.AutoSize = true;
            lblDriversCount.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriversCount.ForeColor = Color.Black;
            lblDriversCount.Location = new Point(210, 20);
            lblDriversCount.Name = "lblDriversCount";
            lblDriversCount.Size = new Size(60, 41);
            lblDriversCount.TabIndex = 8;
            lblDriversCount.Text = " 24";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 0;
            label1.Text = "Availabel Cars";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 89);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 12;
            label2.Text = "Availabel Cars";
            // 
            // tblAllDrivers
            // 
            tblAllDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAllDrivers.Location = new Point(221, 133);
            tblAllDrivers.Name = "tblAllDrivers";
            tblAllDrivers.RowHeadersWidth = 51;
            tblAllDrivers.Size = new Size(416, 386);
            tblAllDrivers.TabIndex = 11;
            tblAllDrivers.CellContentClick += tblAllDrivers_CellContentClick;
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
            panel1.TabIndex = 9;
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
            btnAvailableCar.Text = "Available Cars";
            btnAvailableCar.UseVisualStyleBackColor = true;
            btnAvailableCar.Click += btnAvailableCar_Click;
            // 
            // btnAvailabelDriver
            // 
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
            btnAvailabelDriver.Text = "Available Drivers";
            btnAvailabelDriver.UseVisualStyleBackColor = true;
            btnAvailabelDriver.Click += btnAvailabelDriver_Click;
            // 
            // btnBookNow
            // 
            btnBookNow.BackColor = Color.Black;
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
            btnBookNow.UseVisualStyleBackColor = false;
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
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.White;
            lblUserID.Location = new Point(769, 24);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(119, 20);
            lblUserID.TabIndex = 2;
            lblUserID.Text = "+94 76 706 6455";
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
            panel2.Controls.Add(lblUserID);
            panel2.Controls.Add(imgUser);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 65);
            panel2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 8F);
            label6.Location = new Point(16, 49);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 6;
            label6.Text = "Driver ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 8F);
            label7.Location = new Point(16, 77);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 7;
            label7.Text = "Driver Name :";
            // 
            // lblDriverID
            // 
            lblDriverID.AutoSize = true;
            lblDriverID.Font = new Font("Nirmala UI", 8F);
            lblDriverID.Location = new Point(92, 49);
            lblDriverID.Name = "lblDriverID";
            lblDriverID.Size = new Size(41, 19);
            lblDriverID.TabIndex = 8;
            lblDriverID.Text = "0000";
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Nirmala UI", 8F);
            lblDriverName.Location = new Point(115, 77);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(0, 19);
            lblDriverName.TabIndex = 9;
            // 
            // UserBookNowPage2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 234, 236);
            ClientSize = new Size(960, 540);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(tblAllDrivers);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserBookNowPage2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserBookNowPage2";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Button btnSubCar;
        private TextBox txtPlateNumber;
        private Label label5;
        private TextBox txtCarModel;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Label lblDriversCount;
        private Label label1;
        private Label label2;
        private DataGridView tblAllDrivers;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAvailableCar;
        private FontAwesome.Sharp.IconButton btnAvailabelDriver;
        private FontAwesome.Sharp.IconButton btnBookNow;
        private Button btnClose;
        private Button btnLogOut;
        private PictureBox pictureBox1;
        private Label lblUserID;
        private PictureBox imgUser;
        private Panel panel2;
        private Label lblDriverName;
        private Label lblDriverID;
        private Label label7;
        private Label label6;
    }
}