namespace QuanLyQuanCafe
{
    partial class Register
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtReEnterPass = new TextBox();
            label7 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            errorName = new Label();
            errorPhone = new Label();
            errorUsername = new Label();
            errorPassword = new Label();
            errorReEnterPass = new Label();
            errorTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(219, 184, 142);
            label1.Location = new Point(184, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 54);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.edit;
            pictureBox1.Location = new Point(104, 38);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(219, 184, 142);
            label2.Location = new Point(41, 137);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 2;
            label2.Text = "Full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(219, 184, 142);
            label3.Location = new Point(67, 199);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 3;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(219, 184, 142);
            label4.Location = new Point(41, 262);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(219, 184, 142);
            label5.Location = new Point(44, 328);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(219, 184, 142);
            label6.Location = new Point(49, 379);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 6;
            label6.Text = "Re-enter";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.Window;
            txtFullName.Cursor = Cursors.IBeam;
            txtFullName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFullName.Location = new Point(148, 133);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(231, 27);
            txtFullName.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Window;
            txtPhone.Cursor = Cursors.IBeam;
            txtPhone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhone.Location = new Point(148, 199);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(231, 27);
            txtPhone.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(148, 258);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(231, 27);
            txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(146, 325);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(231, 26);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtReEnterPass
            // 
            txtReEnterPass.BackColor = SystemColors.Window;
            txtReEnterPass.Cursor = Cursors.IBeam;
            txtReEnterPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtReEnterPass.Location = new Point(148, 390);
            txtReEnterPass.Multiline = true;
            txtReEnterPass.Name = "txtReEnterPass";
            txtReEnterPass.Size = new Size(231, 27);
            txtReEnterPass.TabIndex = 12;
            txtReEnterPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(219, 184, 142);
            label7.Location = new Point(49, 402);
            label7.Name = "label7";
            label7.Size = new Size(82, 23);
            label7.TabIndex = 13;
            label7.Text = "password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(219, 184, 142);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(184, 480);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 14;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(210, 527);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 23);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // errorName
            // 
            errorName.AutoSize = true;
            errorName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errorName.ForeColor = Color.Red;
            errorName.Location = new Point(148, 163);
            errorName.Name = "errorName";
            errorName.Size = new Size(0, 20);
            errorName.TabIndex = 16;
            // 
            // errorPhone
            // 
            errorPhone.AutoSize = true;
            errorPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errorPhone.ForeColor = Color.Red;
            errorPhone.Location = new Point(148, 229);
            errorPhone.Name = "errorPhone";
            errorPhone.Size = new Size(0, 20);
            errorPhone.TabIndex = 17;
            // 
            // errorUsername
            // 
            errorUsername.AutoSize = true;
            errorUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errorUsername.ForeColor = Color.Red;
            errorUsername.Location = new Point(148, 288);
            errorUsername.Name = "errorUsername";
            errorUsername.Size = new Size(0, 20);
            errorUsername.TabIndex = 18;
            // 
            // errorPassword
            // 
            errorPassword.AutoSize = true;
            errorPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errorPassword.ForeColor = Color.Red;
            errorPassword.Location = new Point(148, 354);
            errorPassword.Name = "errorPassword";
            errorPassword.Size = new Size(0, 20);
            errorPassword.TabIndex = 19;
            // 
            // errorReEnterPass
            // 
            errorReEnterPass.AutoSize = true;
            errorReEnterPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errorReEnterPass.ForeColor = Color.Red;
            errorReEnterPass.Location = new Point(148, 420);
            errorReEnterPass.Name = "errorReEnterPass";
            errorReEnterPass.Size = new Size(0, 20);
            errorReEnterPass.TabIndex = 20;
            // 
            // errorTotal
            // 
            errorTotal.AutoSize = true;
            errorTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errorTotal.ForeColor = Color.Red;
            errorTotal.Location = new Point(148, 440);
            errorTotal.Name = "errorTotal";
            errorTotal.Size = new Size(0, 20);
            errorTotal.TabIndex = 21;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 561);
            Controls.Add(errorTotal);
            Controls.Add(errorReEnterPass);
            Controls.Add(errorPassword);
            Controls.Add(errorUsername);
            Controls.Add(errorPhone);
            Controls.Add(errorName);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txtReEnterPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            TopMost = true;
            Load += Register_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtReEnterPass;
        private Label label7;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label errorName;
        private Label errorPhone;
        private Label errorUsername;
        private Label errorPassword;
        private Label errorReEnterPass;
        private Label errorTotal;
    }
}