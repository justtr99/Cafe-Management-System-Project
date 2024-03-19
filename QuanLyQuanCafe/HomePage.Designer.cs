namespace QuanLyQuanCafe
{
    partial class HomePage
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
            panel2 = new Panel();
            panelForManager = new Panel();
            btnManager = new Button();
            panel1 = new Panel();
            panelProfile = new Panel();
            btnProfile = new Button();
            panelHoaDon = new Panel();
            btnHoadon = new Button();
            panelGoiDo = new Panel();
            btnGoiDo = new Button();
            pictureBox1 = new PictureBox();
            panelManager = new Panel();
            panel2.SuspendLayout();
            panelForManager.SuspendLayout();
            panelProfile.SuspendLayout();
            panelHoaDon.SuspendLayout();
            panelGoiDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 184, 142);
            panel2.Controls.Add(panelForManager);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panelProfile);
            panel2.Controls.Add(panelHoaDon);
            panel2.Controls.Add(panelGoiDo);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 676);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panelForManager
            // 
            panelForManager.Controls.Add(btnManager);
            panelForManager.Location = new Point(0, 514);
            panelForManager.Name = "panelForManager";
            panelForManager.Size = new Size(225, 60);
            panelForManager.TabIndex = 5;
            // 
            // btnManager
            // 
            btnManager.BackColor = Color.FromArgb(219, 184, 142);
            btnManager.Cursor = Cursors.Hand;
            btnManager.FlatAppearance.BorderColor = Color.FromArgb(219, 184, 142);
            btnManager.FlatAppearance.BorderSize = 0;
            btnManager.FlatStyle = FlatStyle.Flat;
            btnManager.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnManager.ForeColor = Color.White;
            btnManager.Image = Properties.Resources.multitasking__1_;
            btnManager.ImageAlign = ContentAlignment.MiddleRight;
            btnManager.Location = new Point(12, 0);
            btnManager.Name = "btnManager";
            btnManager.Size = new Size(179, 58);
            btnManager.TabIndex = 0;
            btnManager.Text = "Manager";
            btnManager.TextAlign = ContentAlignment.MiddleLeft;
            btnManager.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnManager.UseVisualStyleBackColor = false;
            btnManager.Click += btnManager_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(216, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 662);
            panel1.TabIndex = 2;
            // 
            // panelProfile
            // 
            panelProfile.Controls.Add(btnProfile);
            panelProfile.Location = new Point(0, 429);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(225, 60);
            panelProfile.TabIndex = 4;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(219, 184, 142);
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(219, 184, 142);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.White;
            btnProfile.Image = Properties.Resources.user__2___1_;
            btnProfile.ImageAlign = ContentAlignment.MiddleRight;
            btnProfile.Location = new Point(12, 0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(179, 58);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // panelHoaDon
            // 
            panelHoaDon.Controls.Add(btnHoadon);
            panelHoaDon.Location = new Point(0, 340);
            panelHoaDon.Name = "panelHoaDon";
            panelHoaDon.Size = new Size(228, 60);
            panelHoaDon.TabIndex = 3;
            // 
            // btnHoadon
            // 
            btnHoadon.BackColor = Color.FromArgb(219, 184, 142);
            btnHoadon.Cursor = Cursors.Hand;
            btnHoadon.FlatAppearance.BorderColor = Color.FromArgb(219, 184, 142);
            btnHoadon.FlatAppearance.BorderSize = 0;
            btnHoadon.FlatStyle = FlatStyle.Flat;
            btnHoadon.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHoadon.ForeColor = Color.White;
            btnHoadon.Image = Properties.Resources.note__1_;
            btnHoadon.ImageAlign = ContentAlignment.MiddleRight;
            btnHoadon.Location = new Point(12, 3);
            btnHoadon.Name = "btnHoadon";
            btnHoadon.Size = new Size(179, 58);
            btnHoadon.TabIndex = 0;
            btnHoadon.Text = "Hóa đơn";
            btnHoadon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoadon.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHoadon.UseVisualStyleBackColor = false;
            btnHoadon.Click += btnHoadon_Click;
            // 
            // panelGoiDo
            // 
            panelGoiDo.BackColor = Color.FromArgb(219, 184, 142);
            panelGoiDo.Controls.Add(btnGoiDo);
            panelGoiDo.Location = new Point(-15, 252);
            panelGoiDo.Name = "panelGoiDo";
            panelGoiDo.Size = new Size(225, 60);
            panelGoiDo.TabIndex = 2;
            // 
            // btnGoiDo
            // 
            btnGoiDo.BackColor = Color.FromArgb(219, 184, 142);
            btnGoiDo.Cursor = Cursors.Hand;
            btnGoiDo.FlatAppearance.BorderColor = Color.FromArgb(219, 184, 142);
            btnGoiDo.FlatAppearance.BorderSize = 0;
            btnGoiDo.FlatStyle = FlatStyle.Flat;
            btnGoiDo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoiDo.ForeColor = Color.White;
            btnGoiDo.Image = Properties.Resources.add__1_;
            btnGoiDo.ImageAlign = ContentAlignment.MiddleRight;
            btnGoiDo.Location = new Point(27, 0);
            btnGoiDo.Name = "btnGoiDo";
            btnGoiDo.Size = new Size(179, 58);
            btnGoiDo.TabIndex = 0;
            btnGoiDo.Text = "Gọi đồ";
            btnGoiDo.TextAlign = ContentAlignment.MiddleLeft;
            btnGoiDo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGoiDo.UseVisualStyleBackColor = false;
            btnGoiDo.Click += btnGoiDo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._95_scaled;
            pictureBox1.Location = new Point(-15, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelManager
            // 
            panelManager.Location = new Point(216, 1);
            panelManager.Name = "panelManager";
            panelManager.Size = new Size(1026, 673);
            panelManager.TabIndex = 2;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 674);
            Controls.Add(panelManager);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            panel2.ResumeLayout(false);
            panelForManager.ResumeLayout(false);
            panelProfile.ResumeLayout(false);
            panelHoaDon.ResumeLayout(false);
            panelGoiDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnGoiDo;
        private PictureBox pictureBox1;
        private Panel panelGoiDo;
        private Panel panelProfile;
        private Button btnProfile;
        private Panel panelHoaDon;
        private Button btnHoadon;
        private Panel panel1;
        private Panel panelManager;
        private Panel panelForManager;
        private Button btnManager;
    }
}