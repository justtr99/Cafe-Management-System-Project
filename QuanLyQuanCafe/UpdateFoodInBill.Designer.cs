namespace QuanLyQuanCafe
{
    partial class UpdateFoodInBill
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
            Button button2;
            label1 = new Label();
            label2 = new Label();
            labelFoodName = new Label();
            numerQuatity = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numerQuatity).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(219, 184, 142);
            button2.Location = new Point(274, 145);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(219, 184, 142);
            label1.Location = new Point(94, 39);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên đồ ăn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(219, 184, 142);
            label2.Location = new Point(101, 85);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Số lượng:";
            // 
            // labelFoodName
            // 
            labelFoodName.AutoSize = true;
            labelFoodName.BackColor = SystemColors.ButtonFace;
            labelFoodName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelFoodName.ForeColor = Color.FromArgb(219, 184, 142);
            labelFoodName.Location = new Point(220, 39);
            labelFoodName.Name = "labelFoodName";
            labelFoodName.Size = new Size(74, 25);
            labelFoodName.TabIndex = 2;
            labelFoodName.Text = "Trà sữa";
            // 
            // numerQuatity
            // 
            numerQuatity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numerQuatity.ForeColor = Color.FromArgb(219, 184, 142);
            numerQuatity.Location = new Point(209, 87);
            numerQuatity.Name = "numerQuatity";
            numerQuatity.Size = new Size(124, 27);
            numerQuatity.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(219, 184, 142);
            button1.Location = new Point(66, 145);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateFoodInBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 182);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numerQuatity);
            Controls.Add(labelFoodName);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "UpdateFoodInBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateFoodInBill";
            Load += UpdateFoodInBill_Load;
            ((System.ComponentModel.ISupportInitialize)numerQuatity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelFoodName;
        private NumericUpDown numerQuatity;
        private Button button1;
    }
}