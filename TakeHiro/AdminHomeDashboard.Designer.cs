namespace TakeHiro
{
    partial class AdminHomeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeDashboard));
            panel1 = new Panel();
            btnClose = new Button();
            btnLogOut = new Button();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnManageOrders = new FontAwesome.Sharp.IconButton();
            btnDashBoard = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel7 = new Panel();
            label15 = new Label();
            label18 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            label14 = new Label();
            panel5 = new Panel();
            lblAvailabelCars = new Label();
            lblRegisteredCars = new Label();
            label9 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            lblAvailabelDrivers = new Label();
            lblRegisteredDrivers = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            tblOrder = new DataGridView();
            orderid = new DataGridViewTextBoxColumn();
            customerid = new DataGridViewTextBoxColumn();
            driverid = new DataGridViewTextBoxColumn();
            tblCompleteOrder = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            tblAllDrivers = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblCompleteOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).BeginInit();
            SuspendLayout();
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
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 770);
            panel1.TabIndex = 0;
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
            btnDashBoard.BackColor = Color.Black;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(279, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1090, 64);
            panel2.TabIndex = 1;
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(331, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(972, 175);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(228, 182, 26);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label18);
            panel7.Location = new Point(707, 54);
            panel7.Name = "panel7";
            panel7.Size = new Size(193, 87);
            panel7.TabIndex = 7;
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
            label18.Size = new Size(159, 23);
            label18.TabIndex = 0;
            label18.Text = "Compeleted Orders";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(42, 46, 52);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(478, 54);
            panel6.Name = "panel6";
            panel6.Size = new Size(193, 87);
            panel6.TabIndex = 6;
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
            label14.Size = new Size(75, 25);
            label14.TabIndex = 0;
            label14.Text = "Orders :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(228, 182, 26);
            panel5.Controls.Add(lblAvailabelCars);
            panel5.Controls.Add(lblRegisteredCars);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(251, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(193, 87);
            panel5.TabIndex = 5;
            // 
            // lblAvailabelCars
            // 
            lblAvailabelCars.AutoSize = true;
            lblAvailabelCars.BackColor = Color.Transparent;
            lblAvailabelCars.Font = new Font("Nirmala UI", 9F);
            lblAvailabelCars.ForeColor = Color.Black;
            lblAvailabelCars.Location = new Point(135, 50);
            lblAvailabelCars.Name = "lblAvailabelCars";
            lblAvailabelCars.Size = new Size(25, 20);
            lblAvailabelCars.TabIndex = 4;
            lblAvailabelCars.Text = "38";
            // 
            // lblRegisteredCars
            // 
            lblRegisteredCars.AutoSize = true;
            lblRegisteredCars.BackColor = Color.Transparent;
            lblRegisteredCars.Font = new Font("Nirmala UI", 9F);
            lblRegisteredCars.ForeColor = Color.Black;
            lblRegisteredCars.Location = new Point(135, 17);
            lblRegisteredCars.Name = "lblRegisteredCars";
            lblRegisteredCars.Size = new Size(25, 20);
            lblRegisteredCars.TabIndex = 3;
            lblRegisteredCars.Text = "76";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(15, 50);
            label9.Name = "label9";
            label9.Size = new Size(104, 17);
            label9.TabIndex = 1;
            label9.Text = "Availabale Cars :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(15, 17);
            label10.Name = "label10";
            label10.Size = new Size(108, 17);
            label10.TabIndex = 0;
            label10.Text = "Registered Cars :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(42, 46, 52);
            panel4.Controls.Add(lblAvailabelDrivers);
            panel4.Controls.Add(lblRegisteredDrivers);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(24, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(193, 87);
            panel4.TabIndex = 1;
            // 
            // lblAvailabelDrivers
            // 
            lblAvailabelDrivers.AutoSize = true;
            lblAvailabelDrivers.BackColor = Color.Transparent;
            lblAvailabelDrivers.Font = new Font("Nirmala UI", 9F);
            lblAvailabelDrivers.ForeColor = Color.White;
            lblAvailabelDrivers.Location = new Point(135, 50);
            lblAvailabelDrivers.Name = "lblAvailabelDrivers";
            lblAvailabelDrivers.Size = new Size(25, 20);
            lblAvailabelDrivers.TabIndex = 4;
            lblAvailabelDrivers.Text = "38";
            // 
            // lblRegisteredDrivers
            // 
            lblRegisteredDrivers.AutoSize = true;
            lblRegisteredDrivers.BackColor = Color.Transparent;
            lblRegisteredDrivers.Font = new Font("Nirmala UI", 9F);
            lblRegisteredDrivers.ForeColor = Color.White;
            lblRegisteredDrivers.Location = new Point(135, 17);
            lblRegisteredDrivers.Name = "lblRegisteredDrivers";
            lblRegisteredDrivers.Size = new Size(25, 20);
            lblRegisteredDrivers.TabIndex = 3;
            lblRegisteredDrivers.Text = "76";
            lblRegisteredDrivers.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 50);
            label4.Name = "label4";
            label4.Size = new Size(119, 17);
            label4.TabIndex = 1;
            label4.Text = "Availabale Drivers :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 17);
            label2.Name = "label2";
            label2.Size = new Size(123, 17);
            label2.TabIndex = 0;
            label2.Text = "Registered Drivers :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 16);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 0;
            label3.Text = "Statistics";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(336, 304);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 3;
            label5.Text = "All Ordrs";
            // 
            // tblOrder
            // 
            tblOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblOrder.Columns.AddRange(new DataGridViewColumn[] { orderid, customerid, driverid });
            tblOrder.Location = new Point(343, 351);
            tblOrder.Name = "tblOrder";
            tblOrder.RowHeadersWidth = 51;
            tblOrder.Size = new Size(450, 387);
            tblOrder.StandardTab = true;
            tblOrder.TabIndex = 4;
            // 
            // orderid
            // 
            orderid.HeaderText = "Order ID";
            orderid.MinimumWidth = 6;
            orderid.Name = "orderid";
            // 
            // customerid
            // 
            customerid.HeaderText = "Customer ID ";
            customerid.MinimumWidth = 6;
            customerid.Name = "customerid";
            // 
            // driverid
            // 
            driverid.HeaderText = "Driver ID";
            driverid.MinimumWidth = 6;
            driverid.Name = "driverid";
            // 
            // tblCompleteOrder
            // 
            tblCompleteOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblCompleteOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblCompleteOrder.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            tblCompleteOrder.Location = new Point(853, 351);
            tblCompleteOrder.Name = "tblCompleteOrder";
            tblCompleteOrder.RowHeadersWidth = 51;
            tblCompleteOrder.Size = new Size(450, 158);
            tblCompleteOrder.StandardTab = true;
            tblCompleteOrder.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Order ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Customer ID ";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Driver ID";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(853, 304);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 5;
            label6.Text = "Complete Ordrs";
            label6.Click += label6_Click;
            // 
            // tblAllDrivers
            // 
            tblAllDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblAllDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAllDrivers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            tblAllDrivers.Location = new Point(853, 580);
            tblAllDrivers.Name = "tblAllDrivers";
            tblAllDrivers.RowHeadersWidth = 51;
            tblAllDrivers.Size = new Size(450, 158);
            tblAllDrivers.StandardTab = true;
            tblAllDrivers.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Driver ID";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Name";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Tp Number";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(853, 540);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 7;
            label7.Text = "All Drivers";
            // 
            // AdminHomeDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 234, 236);
            ClientSize = new Size(1366, 768);
            Controls.Add(tblAllDrivers);
            Controls.Add(label7);
            Controls.Add(tblCompleteOrder);
            Controls.Add(label6);
            Controls.Add(tblOrder);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminHomeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminHomeDashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblCompleteOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblAllDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnDashBoard;
        private FontAwesome.Sharp.IconButton btnManageOrders;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button btnClose;
        private Button btnLogOut;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label lblAvailabelDrivers;
        private Label lblRegisteredDrivers;
        private Label label4;
        private Label label2;
        private Panel panel7;
        private Label label15;
        private Label label18;
        private Panel panel6;
        private Label label11;
        private Label label14;
        private Panel panel5;
        private Label lblAvailabelCars;
        private Label lblRegisteredCars;
        private Label label9;
        private Label label10;
        private Label label5;
        private DataGridView tblOrder;
        private DataGridViewTextBoxColumn orderid;
        private DataGridViewTextBoxColumn customerid;
        private DataGridViewTextBoxColumn driverid;
        private DataGridView tblCompleteOrder;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label6;
        private DataGridView tblAllDrivers;
        private Label label7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}