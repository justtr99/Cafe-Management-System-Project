namespace QuanLyQuanCafe
{
    partial class ChangePass
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textOldPass = new TextBox();
            textNewPass = new TextBox();
            label3 = new Label();
            textEnterAgain = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            errorEnterAgain = new Label();
            errorOldPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.reset_password__1_;
            pictureBox1.Location = new Point(44, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(219, 184, 142);
            label1.Location = new Point(150, 64);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 54);
            label1.TabIndex = 1;
            label1.Text = "Change password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(219, 184, 142);
            label2.Location = new Point(57, 176);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu cũ:";
            // 
            // textOldPass
            // 
            textOldPass.Location = new Point(207, 176);
            textOldPass.Name = "textOldPass";
            textOldPass.Size = new Size(257, 27);
            textOldPass.TabIndex = 3;
            textOldPass.UseSystemPasswordChar = true;
            // 
            // textNewPass
            // 
            textNewPass.Location = new Point(207, 244);
            textNewPass.Name = "textNewPass";
            textNewPass.Size = new Size(257, 27);
            textNewPass.TabIndex = 5;
            textNewPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(219, 184, 142);
            label3.Location = new Point(43, 243);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu mới:";
            // 
            // textEnterAgain
            // 
            textEnterAgain.Location = new Point(207, 312);
            textEnterAgain.Name = "textEnterAgain";
            textEnterAgain.Size = new Size(257, 27);
            textEnterAgain.TabIndex = 7;
            textEnterAgain.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(219, 184, 142);
            label4.Location = new Point(89, 311);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 6;
            label4.Text = "Nhập lại :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(219, 184, 142);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(224, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // errorEnterAgain
            // 
            errorEnterAgain.AutoSize = true;
            errorEnterAgain.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            errorEnterAgain.ForeColor = Color.Red;
            errorEnterAgain.Location = new Point(207, 342);
            errorEnterAgain.Name = "errorEnterAgain";
            errorEnterAgain.Size = new Size(0, 23);
            errorEnterAgain.TabIndex = 9;
            // 
            // errorOldPass
            // 
            errorOldPass.AutoSize = true;
            errorOldPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            errorOldPass.ForeColor = Color.Red;
            errorOldPass.Location = new Point(207, 206);
            errorOldPass.Name = "errorOldPass";
            errorOldPass.Size = new Size(0, 23);
            errorOldPass.TabIndex = 10;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 450);
            Controls.Add(errorOldPass);
            Controls.Add(errorEnterAgain);
            Controls.Add(btnSave);
            Controls.Add(textEnterAgain);
            Controls.Add(label4);
            Controls.Add(textNewPass);
            Controls.Add(label3);
            Controls.Add(textOldPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonHighlight;
            MaximizeBox = false;
            Name = "ChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePass";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textOldPass;
        private TextBox textNewPass;
        private Label label3;
        private TextBox textEnterAgain;
        private Label label4;
        private Button btnSave;
        private Label errorEnterAgain;
        private Label errorOldPass;
    }
}