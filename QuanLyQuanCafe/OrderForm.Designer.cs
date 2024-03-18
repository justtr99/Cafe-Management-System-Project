namespace QuanLyQuanCafe
{
    partial class OrderForm
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtTable = new TextBox();
            cbRoom = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnAddFood = new Button();
            listViewBill = new ListView();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            cbDoiRoom = new ComboBox();
            btnChuyenBan = new Button();
            btnThanhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flpListTable
            // 
            flpListTable.BackColor = Color.FromArgb(239, 226, 211);
            flpListTable.Location = new Point(3, 12);
            flpListTable.Name = "flpListTable";
            flpListTable.Size = new Size(604, 654);
            flpListTable.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(116, 76, 31);
            panel1.Location = new Point(613, -79);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 791);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(219, 184, 142);
            label1.Location = new Point(623, 12);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 2;
            label1.Text = "Order";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.note__2_;
            pictureBox1.Location = new Point(693, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtTable
            // 
            txtTable.Location = new Point(693, 55);
            txtTable.Multiline = true;
            txtTable.Name = "txtTable";
            txtTable.Size = new Size(167, 28);
            txtTable.TabIndex = 4;
            txtTable.TextChanged += txtTable_TextChanged;
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(693, 98);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(167, 28);
            cbRoom.TabIndex = 5;
            cbRoom.SelectedValueChanged += cbRoom_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(219, 184, 142);
            label2.Location = new Point(641, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 6;
            label2.Text = "Bàn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(219, 184, 142);
            label3.Location = new Point(623, 99);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 7;
            label3.Text = "Phòng:";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.FromArgb(219, 184, 142);
            btnAddFood.Cursor = Cursors.Hand;
            btnAddFood.FlatAppearance.BorderSize = 0;
            btnAddFood.FlatStyle = FlatStyle.Flat;
            btnAddFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.ForeColor = SystemColors.ButtonHighlight;
            btnAddFood.Location = new Point(892, 91);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(112, 39);
            btnAddFood.TabIndex = 8;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // listViewBill
            // 
            listViewBill.FullRowSelect = true;
            listViewBill.GridLines = true;
            listViewBill.Location = new Point(626, 132);
            listViewBill.Name = "listViewBill";
            listViewBill.Size = new Size(388, 382);
            listViewBill.TabIndex = 9;
            listViewBill.UseCompatibleStateImageBehavior = false;
            listViewBill.View = View.Details;
            listViewBill.DoubleClick += listViewBill_DoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(219, 184, 142);
            label4.Location = new Point(640, 529);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 10;
            label4.Text = "Tổng tiền:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.FromArgb(219, 184, 142);
            richTextBox1.Location = new Point(765, 529);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(216, 35);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "0 đ";
            // 
            // cbDoiRoom
            // 
            cbDoiRoom.FormattingEnabled = true;
            cbDoiRoom.Location = new Point(626, 599);
            cbDoiRoom.Name = "cbDoiRoom";
            cbDoiRoom.Size = new Size(112, 28);
            cbDoiRoom.TabIndex = 12;
            // 
            // btnChuyenBan
            // 
            btnChuyenBan.BackColor = Color.FromArgb(219, 184, 142);
            btnChuyenBan.Cursor = Cursors.Hand;
            btnChuyenBan.FlatAppearance.BorderSize = 0;
            btnChuyenBan.FlatStyle = FlatStyle.Flat;
            btnChuyenBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChuyenBan.ForeColor = SystemColors.ButtonHighlight;
            btnChuyenBan.Location = new Point(751, 593);
            btnChuyenBan.Name = "btnChuyenBan";
            btnChuyenBan.Size = new Size(109, 39);
            btnChuyenBan.TabIndex = 13;
            btnChuyenBan.Text = "Chuyển bàn";
            btnChuyenBan.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(219, 184, 142);
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.ForeColor = SystemColors.ButtonHighlight;
            btnThanhToan.Location = new Point(895, 593);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(109, 39);
            btnThanhToan.TabIndex = 14;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 623);
            Controls.Add(btnThanhToan);
            Controls.Add(btnChuyenBan);
            Controls.Add(cbDoiRoom);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(listViewBill);
            Controls.Add(btnAddFood);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbRoom);
            Controls.Add(txtTable);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(flpListTable);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpListTable;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtTable;
        private ComboBox cbRoom;
        private Label label2;
        private Label label3;
        private Button btnAddFood;
        private ListView listViewBill;
        private Label label4;
        private RichTextBox richTextBox1;
        private ComboBox cbDoiRoom;
        private Button btnChuyenBan;
        private Button btnThanhToan;
    }
}