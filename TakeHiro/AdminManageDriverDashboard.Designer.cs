namespace TakeHiro
{
    partial class AdminManageDriverDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageDriverDashboard));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnClose = new Button();
            btnLogOut = new Button();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnManageOrders = new FontAwesome.Sharp.IconButton();
            btnDashBoard = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tblAllDrivers = new DataGridView();
            label7 = new Label();
            panel3 = new Panel();
            btnAddNewDriver = new Button();
            btnSubmitChnages = new Button();
            btnRemoveDriver = new Button();
            txtDriverName = new TextBox();
            cmbAvailability = new ComboBox();
            label4 = new Label();
            txtContactNumber = new TextBox();
            label5 = new Label();
            label8 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            label14 = new Label();
            panel7 = new Panel();
            label15 = new Label();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
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
            iconButton2.BackColor = Color.FromArgb(42, 46, 52);
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
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Black;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(278, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1090, 64);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(871, 19);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 1;
            label1.Text = "+94 76 706 6455";
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
            // tblAllDrivers
            // 
            tblAllDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblAllDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAllDrivers.Location = new Point(353, 122);
            tblAllDrivers.Name = "tblAllDrivers";
            tblAllDrivers.RowHeadersWidth = 51;
            tblAllDrivers.Size = new Size(954, 250);
            tblAllDrivers.StandardTab = true;
            tblAllDrivers.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(353, 82);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 13;
            label7.Text = "All Drivers";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnAddNewDriver);
            panel3.Controls.Add(btnSubmitChnages);
            panel3.Controls.Add(btnRemoveDriver);
            panel3.Controls.Add(txtDriverName);
            panel3.Controls.Add(cmbAvailability);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtContactNumber);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(353, 404);
            panel3.Name = "panel3";
            panel3.Size = new Size(728, 338);
            panel3.TabIndex = 15;
            // 
            // btnAddNewDriver
            // 
            btnAddNewDriver.BackColor = Color.FromArgb(42, 46, 52);
            btnAddNewDriver.FlatStyle = FlatStyle.Flat;
            btnAddNewDriver.ForeColor = Color.White;
            btnAddNewDriver.Location = new Point(398, 190);
            btnAddNewDriver.Name = "btnAddNewDriver";
            btnAddNewDriver.Size = new Size(302, 40);
            btnAddNewDriver.TabIndex = 30;
            btnAddNewDriver.Text = "Add New Driver";
            btnAddNewDriver.UseVisualStyleBackColor = false;
            btnAddNewDriver.Click += btnAddNewDriver_Click;
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
            // 
            // btnRemoveDriver
            // 
            btnRemoveDriver.BackColor = Color.FromArgb(42, 46, 52);
            btnRemoveDriver.FlatStyle = FlatStyle.Flat;
            btnRemoveDriver.ForeColor = Color.White;
            btnRemoveDriver.Location = new Point(398, 282);
            btnRemoveDriver.Name = "btnRemoveDriver";
            btnRemoveDriver.Size = new Size(302, 40);
            btnRemoveDriver.TabIndex = 28;
            btnRemoveDriver.Text = "Remove Driver";
            btnRemoveDriver.UseVisualStyleBackColor = false;
            // 
            // txtDriverName
            // 
            txtDriverName.BorderStyle = BorderStyle.FixedSingle;
            txtDriverName.Location = new Point(16, 93);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(302, 30);
            txtDriverName.TabIndex = 27;
            // 
            // cmbAvailability
            // 
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Location = new Point(16, 236);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(302, 31);
            cmbAvailability.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 211);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 25;
            label4.Text = "Driver Availability";
            // 
            // txtContactNumber
            // 
            txtContactNumber.BorderStyle = BorderStyle.FixedSingle;
            txtContactNumber.Location = new Point(16, 165);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(302, 30);
            txtContactNumber.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 139);
            label5.Name = "label5";
            label5.Size = new Size(188, 23);
            label5.TabIndex = 23;
            label5.Text = "Driver Contact Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 67);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 21;
            label8.Text = "Driver Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 13);
            label2.Name = "label2";
            label2.Size = new Size(215, 25);
            label2.TabIndex = 18;
            label2.Text = "Driver Application Form";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(42, 46, 52);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(1106, 404);
            panel6.Name = "panel6";
            panel6.Size = new Size(201, 87);
            panel6.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Nirmala UI", 14F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(138, 41);
            label11.Name = "label11";
            label11.Size = new Size(40, 32);
            label11.TabIndex = 4;
            label11.Text = "38";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(13, 11);
            label14.Name = "label14";
            label14.Size = new Size(155, 25);
            label14.TabIndex = 0;
            label14.Text = "Registered Drivers";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(228, 182, 26);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label18);
            panel7.Location = new Point(1106, 517);
            panel7.Name = "panel7";
            panel7.Size = new Size(201, 87);
            panel7.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Nirmala UI", 14F);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(133, 41);
            label15.Name = "label15";
            label15.Size = new Size(40, 32);
            label15.TabIndex = 4;
            label15.Text = "12";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Nirmala UI", 10F);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(14, 13);
            label18.Name = "label18";
            label18.Size = new Size(135, 23);
            label18.TabIndex = 0;
            label18.Text = "Availabel Drivers";
            // 
            // AdminManageDriverDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(tblAllDrivers);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageDriverDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageDriverDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnClose;
        private Button btnLogOut;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnManageOrders;
        private FontAwesome.Sharp.IconButton btnDashBoard;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridView tblAllDrivers;
        private Label label7;
        private Panel panel3;
        private Label label2;
        private Panel panel6;
        private Label label11;
        private Label label14;
        private Panel panel7;
        private Label label15;
        private Label label18;
        private TextBox txtDriverName;
        private ComboBox cmbAvailability;
        private Label label4;
        private TextBox txtContactNumber;
        private Label label5;
        private Label label8;
        private Button btnAddNewDriver;
        private Button btnSubmitChnages;
        private Button btnRemoveDriver;
    }
}