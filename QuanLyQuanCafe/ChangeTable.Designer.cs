namespace QuanLyQuanCafe
{
    partial class ChangeTable
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
            flpListTable = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbRoom = new ComboBox();
            txtTable = new TextBox();
            SuspendLayout();
            // 
            // flpListTable
            // 
            flpListTable.BackColor = Color.FromArgb(239, 226, 211);
            flpListTable.Location = new Point(12, 154);
            flpListTable.Name = "flpListTable";
            flpListTable.Size = new Size(984, 409);
            flpListTable.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(219, 184, 142);
            label1.Location = new Point(424, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 2;
            label1.Text = "Đổi bàn";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(219, 184, 142);
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "Phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(219, 184, 142);
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên bàn";
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(106, 108);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(200, 28);
            cbRoom.TabIndex = 5;
            cbRoom.SelectedValueChanged += cbRoom_SelectedValueChanged;
            // 
            // txtTable
            // 
            txtTable.Location = new Point(106, 59);
            txtTable.Name = "txtTable";
            txtTable.Size = new Size(200, 27);
            txtTable.TabIndex = 6;
            txtTable.TextChanged += txtTable_TextChanged;
            // 
            // ChangeTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 650);
            Controls.Add(txtTable);
            Controls.Add(cbRoom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flpListTable);
            Name = "ChangeTable";
            Text = "ChangeTable";
            Load += ChangeTable_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpListTable;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbRoom;
        private TextBox txtTable;
    }
}