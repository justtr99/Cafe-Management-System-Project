namespace QuanLyQuanCafe
{
    partial class ProfileForm
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
            pictureBox2 = new PictureBox();
            btnProfile = new Button();
            btnChangePass = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.welcome_back__1_;
            pictureBox2.Location = new Point(205, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(622, 343);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(219, 184, 142);
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.Transparent;
            btnProfile.Location = new Point(390, 418);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(248, 48);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(219, 184, 142);
            btnChangePass.Cursor = Cursors.Hand;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePass.ForeColor = Color.Transparent;
            btnChangePass.Location = new Point(390, 486);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(248, 48);
            btnChangePass.TabIndex = 5;
            btnChangePass.Text = "Change password";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(219, 184, 142);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Location = new Point(390, 555);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(248, 48);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(219, 184, 142);
            pictureBox1.Image = Properties.Resources.user__3_;
            pictureBox1.Location = new Point(390, 428);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(219, 184, 142);
            pictureBox3.Image = Properties.Resources.reset_password;
            pictureBox3.Location = new Point(390, 495);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(219, 184, 142);
            pictureBox4.Image = Properties.Resources.logout;
            pictureBox4.Location = new Point(390, 565);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 623);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnChangePass);
            Controls.Add(btnProfile);
            Controls.Add(pictureBox2);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnProfile;
        private Button btnChangePass;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}