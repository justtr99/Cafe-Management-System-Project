namespace QuanLyQuanCafe
{
    partial class ViewProfile
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
            lebelFullName = new Label();
            labelUsername = new Label();
            label3 = new Label();
            labelSdt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contributor_agreement;
            pictureBox1.Location = new Point(43, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(562, 514);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lebelFullName
            // 
            lebelFullName.AutoSize = true;
            lebelFullName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lebelFullName.Location = new Point(199, 375);
            lebelFullName.Name = "lebelFullName";
            lebelFullName.Size = new Size(85, 23);
            lebelFullName.TabIndex = 1;
            lebelFullName.Text = "Full name";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(199, 428);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(85, 23);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-18, 522);
            label3.Name = "label3";
            label3.Size = new Size(17, 23);
            label3.TabIndex = 3;
            label3.Text = "s";
            // 
            // labelSdt
            // 
            labelSdt.AutoSize = true;
            labelSdt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelSdt.Location = new Point(199, 484);
            labelSdt.Name = "labelSdt";
            labelSdt.Size = new Size(85, 23);
            labelSdt.TabIndex = 4;
            labelSdt.Text = "Full name";
            // 
            // ViewProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 679);
            Controls.Add(labelSdt);
            Controls.Add(label3);
            Controls.Add(labelUsername);
            Controls.Add(lebelFullName);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "ViewProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewProfile";
            Load += ViewProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lebelFullName;
        private Label labelUsername;
        private Label label3;
        private Label labelSdt;
    }
}