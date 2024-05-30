namespace TakeHiro
{
    partial class AdminManageCarDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageCarDashboard));
            panel6 = new Panel();
            lblRegCars = new Label();
            label14 = new Label();
            btnAddNewCar = new Button();
            btnSubmitChnages = new Button();
            btnRemoveCar = new Button();
            panel3 = new Panel();
            btnClear = new Button();
            label1 = new Label();
            lblCarID = new Label();
            txtCarModel = new TextBox();
            cmbAvailability = new ComboBox();
            label4 = new Label();
            txtCarNumber = new TextBox();
            label5 = new Label();
            label8 = new Label();
            label2 = new Label();
            tblAllDrivers = new DataGridView();
            btnClose = new Button();
            btnLogOut = new Button();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnManageOrders = new FontAwesome.Sharp.IconButton();
            btnDashBoard = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            lblAvaCars = new Label();
            label18 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(42, 46, 52);
            panel6.Controls.Add(lblRegCars);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(1090, 379);
            panel6.Name = "panel6";
            panel6.Size = new Size(201, 87);
            panel6.TabIndex = 23;
            // 
            // lblRegCars
            // 
            lblRegCars.AutoSize = true;
            lblRegCars.BackColor = Color.Transparent;
            lblRegCars.Font = new Font("Nirmala UI", 14F);
            lblRegCars.ForeColor = Color.White;
            lblRegCars.Location = new Point(138, 41);
            lblRegCars.Name = "lblRegCars";
            lblRegCars.Size = new Size(40, 32);
            lblRegCars.TabIndex = 4;
            lblRegCars.Text = "38";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(13, 11);
            label14.Name = "label14";
            label14.Size = new Size(134, 25);
            label14.TabIndex = 0;
            label14.Text = "Registered Cars";
            // 
            // btnAddNewCar
            // 
            btnAddNewCar.BackColor = Color.FromArgb(42, 46, 52);
            btnAddNewCar.FlatStyle = FlatStyle.Flat;
            btnAddNewCar.ForeColor = Color.White;
            btnAddNewCar.Location = new Point(398, 190);
            btnAddNewCar.Name = "btnAddNewCar";
            btnAddNewCar.Size = new Size(302, 40);
            btnAddNewCar.TabIndex = 30;
            btnAddNewCar.Text = "Add New Car";
            btnAddNewCar.UseVisualStyleBackColor = false;
            btnAddNewCar.Click += btnAddNewCar_Click;
            // 
            // btnSubmitChnages
            // 
            btnSubmitChnages.BackColor = Color.FromArgb(42, 46, 52);
            btnSubmitChnages.FlatStyle = FlatStyle.Flat;
            btnSubmitChnages.ForeColor = Color.White;
            btnSubmitChnages.Location = new Point(398, 236);
            btnSubmitChnages.Name = "btnSubmitChnages";
            btnSubmitChnages.Size = new Size(302, 40);
            btnSubmitChnages.TabIndex = 29;
            btnSubmitChnages.Text = "Submit Chnages";
            btnSubmitChnages.UseVisualStyleBackColor = false;
            btnSubmitChnages.Click += btnSubmitChnages_Click;
            // 
            // btnRemoveCar
            // 
            btnRemoveCar.BackColor = Color.FromArgb(42, 46, 52);
            btnRemoveCar.FlatStyle = FlatStyle.Flat;
            btnRemoveCar.ForeColor = Color.White;
            btnRemoveCar.Location = new Point(398, 282);
            btnRemoveCar.Name = "btnRemoveCar";
            btnRemoveCar.Size = new Size(302, 40);
            btnRemoveCar.TabIndex = 28;
            btnRemoveCar.Text = "Remove Car";
            btnRemoveCar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblCarID);
            panel3.Controls.Add(btnAddNewCar);
            panel3.Controls.Add(btnSubmitChnages);
            panel3.Controls.Add(btnRemoveCar);
            panel3.Controls.Add(txtCarModel);
            panel3.Controls.Add(cmbAvailability);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtCarNumber);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(337, 379);
            panel3.Name = "panel3";
            panel3.Size = new Size(728, 338);
            panel3.TabIndex = 22;
            panel3.Paint += panel3_Paint;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(42, 46, 52);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(398, 144);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(302, 40);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear Text Box";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 67);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 32;
            label1.Text = "Car ID :";
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(217, 67);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(33, 20);
            lblCarID.TabIndex = 31;
            lblCarID.Text = "000";
            // 
            // txtCarModel
            // 
            txtCarModel.BorderStyle = BorderStyle.FixedSingle;
            txtCarModel.Location = new Point(16, 93);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(302, 27);
            txtCarModel.TabIndex = 27;
            // 
            // cmbAvailability
            // 
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Location = new Point(16, 236);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(302, 28);
            cmbAvailability.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 211);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 25;
            label4.Text = "Driver Availability";
            // 
            // txtCarNumber
            // 
            txtCarNumber.BorderStyle = BorderStyle.FixedSingle;
            txtCarNumber.Location = new Point(16, 165);
            txtCarNumber.Name = "txtCarNumber";
            txtCarNumber.Size = new Size(302, 27);
            txtCarNumber.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 139);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 23;
            label5.Text = "Car Plate Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 67);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 21;
            label8.Text = "Car Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 13);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 18;
            label2.Text = "Car Application Form";
            // 
            // tblAllDrivers
            // 
            tblAllDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblAllDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAllDrivers.Location = new Point(337, 97);
            tblAllDrivers.Name = "tblAllDrivers";
            tblAllDrivers.RowHeadersWidth = 51;
            tblAllDrivers.Size = new Size(954, 250);
            tblAllDrivers.StandardTab = true;
            tblAllDrivers.TabIndex = 21;
            tblAllDrivers.CellContentClick += tblAllDrivers_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(233, 234, 236);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(12, 678);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(254, 35);
            btnClose.TabIndex = 8;
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
            btnLogOut.Location = new Point(12, 719);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(254, 35);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Log Out ";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Black;
            iconButton2.BackgroundImageLayout = ImageLayout.None;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 12, 12);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.AnglesRight;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleRight;
            iconButton2.Location = new Point(0, 327);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(0, 0, 10, 0);
            iconButton2.Size = new Size(276, 54);
            iconButton2.TabIndex = 4;
            iconButton2.Text = "Manage Cars";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(42, 46, 52);
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 12, 12);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.AnglesRight;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.MiddleRight;
            iconButton1.Location = new Point(0, 267);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(0, 0, 10, 0);
            iconButton1.Size = new Size(276, 54);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Manage Drivers";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnManageOrders
            // 
            btnManageOrders.BackColor = Color.FromArgb(42, 46, 52);
            btnManageOrders.BackgroundImageLayout = ImageLayout.None;
            btnManageOrders.FlatAppearance.BorderSize = 0;
            btnManageOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 12, 12);
            btnManageOrders.FlatStyle = FlatStyle.Flat;
            btnManageOrders.ForeColor = Color.White;
            btnManageOrders.IconChar = FontAwesome.Sharp.IconChar.AnglesRight;
            btnManageOrders.IconColor = Color.White;
            btnManageOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnManageOrders.IconSize = 20;
            btnManageOrders.ImageAlign = ContentAlignment.MiddleRight;
            btnManageOrders.Location = new Point(0, 207);
            btnManageOrders.Name = "btnManageOrders";
            btnManageOrders.Padding = new Padding(0, 0, 10, 0);
            btnManageOrders.Size = new Size(276, 54);
            btnManageOrders.TabIndex = 2;
            btnManageOrders.Text = "Manage Orders";
            btnManageOrders.UseVisualStyleBackColor = false;
            btnManageOrders.Click += btnManageOrders_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.BackColor = Color.FromArgb(42, 46, 52);
            btnDashBoard.BackgroundImageLayout = ImageLayout.None;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 12, 12);
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.ForeColor = Color.White;
            btnDashBoard.IconChar = FontAwesome.Sharp.IconChar.AnglesRight;
            btnDashBoard.IconColor = Color.White;
            btnDashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashBoard.IconSize = 20;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleRight;
            btnDashBoard.Location = new Point(0, 147);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Padding = new Padding(0, 0, 10, 0);
            btnDashBoard.Size = new Size(276, 54);
            btnDashBoard.TabIndex = 1;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = false;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 46, 52);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnManageOrders);
            panel1.Controls.Add(btnDashBoard);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 770);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1032, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(228, 182, 26);
            panel7.Controls.Add(lblAvaCars);
            panel7.Controls.Add(label18);
            panel7.Location = new Point(1090, 492);
            panel7.Name = "panel7";
            panel7.Size = new Size(201, 87);
            panel7.TabIndex = 24;
            // 
            // lblAvaCars
            // 
            lblAvaCars.AutoSize = true;
            lblAvaCars.BackColor = Color.Transparent;
            lblAvaCars.Font = new Font("Nirmala UI", 14F);
            lblAvaCars.ForeColor = Color.Black;
            lblAvaCars.Location = new Point(133, 41);
            lblAvaCars.Name = "lblAvaCars";
            lblAvaCars.Size = new Size(40, 32);
            lblAvaCars.TabIndex = 4;
            lblAvaCars.Text = "12";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Nirmala UI", 10F);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(14, 13);
            label18.Name = "label18";
            label18.Size = new Size(116, 23);
            label18.TabIndex = 0;
            label18.Text = "Availabel Cars";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(278, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1090, 64);
            panel2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14F, FontStyle.Bold);
            label3.Location = new Point(37, 12);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 8;
            label3.Text = "Manage Car Details";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // AdminManageCarDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 234, 236);
            ClientSize = new Size(1366, 768);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(tblAllDrivers);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageCarDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageCarDashboard";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Label lblRegCars;
        private Label label14;
        private Button btnAddNewCar;
        private Button btnSubmitChnages;
        private Button btnRemoveCar;
        private Panel panel3;
        private TextBox txtCarModel;
        private ComboBox cmbAvailability;
        private Label label4;
        private TextBox txtCarNumber;
        private Label label5;
        private Label label8;
        private Label label2;
        private DataGridView tblAllDrivers;
        private Button btnClose;
        private Button btnLogOut;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnManageOrders;
        private FontAwesome.Sharp.IconButton btnDashBoard;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Label lblAvaCars;
        private Label label18;
        private Panel panel2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label lblCarID;
        private Label label1;
        private Button btnClear;
        private Label label3;
    }
}