namespace TakeHiro
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPwd = new TextBox();
            btnSignIn = new Button();
            label4 = new Label();
            txtbtnSignUp = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 46, 52);
            panel1.Controls.Add(pictureBox1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Black;
            label1.Name = "label1";
            label1.Click += label1_Click_1;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txtPwd
            // 
            txtPwd.BackColor = Color.White;
            txtPwd.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtPwd, "txtPwd");
            txtPwd.Name = "txtPwd";
            txtPwd.TextChanged += txtPwd_TextChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(42, 46, 52);
            resources.ApplyResources(btnSignIn, "btnSignIn");
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Name = "btnSignIn";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // txtbtnSignUp
            // 
            resources.ApplyResources(txtbtnSignUp, "txtbtnSignUp");
            txtbtnSignUp.ForeColor = Color.FromArgb(228, 182, 26);
            txtbtnSignUp.Name = "txtbtnSignUp";
            txtbtnSignUp.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtbtnSignUp);
            Controls.Add(label4);
            Controls.Add(btnSignIn);
            Controls.Add(label3);
            Controls.Add(txtPwd);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            Load += LoginPage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtPwd;
        private Button btnSignIn;
        private Label label4;
        private Button txtbtnSignUp;
    }
}
