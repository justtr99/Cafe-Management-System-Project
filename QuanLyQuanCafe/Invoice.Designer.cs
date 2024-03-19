namespace QuanLyQuanCafe
{
    partial class Invoice
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
            btnThongke = new Button();
            label21 = new Label();
            label20 = new Label();
            dateEnd = new DateTimePicker();
            dateStart = new DateTimePicker();
            Page = new Label();
            btnNext = new Button();
            btnBefore = new Button();
            listBillInfo = new ListView();
            label1 = new Label();
            btnExportBill = new Button();
            SuspendLayout();
            // 
            // flpListTable
            // 
            flpListTable.AutoScroll = true;
            flpListTable.BackColor = Color.FromArgb(239, 226, 211);
            flpListTable.Location = new Point(4, 75);
            flpListTable.Name = "flpListTable";
            flpListTable.Size = new Size(703, 536);
            flpListTable.TabIndex = 1;
            // 
            // btnThongke
            // 
            btnThongke.BackColor = Color.FromArgb(219, 184, 142);
            btnThongke.Cursor = Cursors.Hand;
            btnThongke.FlatAppearance.BorderSize = 0;
            btnThongke.FlatStyle = FlatStyle.Flat;
            btnThongke.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongke.ForeColor = SystemColors.ButtonHighlight;
            btnThongke.Location = new Point(554, 16);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(128, 40);
            btnThongke.TabIndex = 11;
            btnThongke.Text = "Thống kê";
            btnThongke.UseVisualStyleBackColor = false;
            btnThongke.Click += btnThongke_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.ButtonFace;
            label21.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(219, 184, 142);
            label21.Location = new Point(269, 25);
            label21.Name = "label21";
            label21.Size = new Size(88, 23);
            label21.TabIndex = 10;
            label21.Text = "Đến ngày:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(219, 184, 142);
            label20.Location = new Point(0, 24);
            label20.Name = "label20";
            label20.Size = new Size(77, 23);
            label20.TabIndex = 9;
            label20.Text = "Từ ngày:";
            // 
            // dateEnd
            // 
            dateEnd.Format = DateTimePickerFormat.Short;
            dateEnd.Location = new Point(363, 23);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(127, 27);
            dateEnd.TabIndex = 8;
            // 
            // dateStart
            // 
            dateStart.Format = DateTimePickerFormat.Short;
            dateStart.Location = new Point(83, 23);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(127, 27);
            dateStart.TabIndex = 7;
            // 
            // Page
            // 
            Page.AutoSize = true;
            Page.BackColor = Color.FromArgb(219, 184, 142);
            Page.ForeColor = SystemColors.ButtonHighlight;
            Page.Location = new Point(581, 631);
            Page.Name = "Page";
            Page.Size = new Size(31, 20);
            Page.TabIndex = 15;
            Page.Text = "0/0";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(219, 184, 142);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(624, 627);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(58, 29);
            btnNext.TabIndex = 14;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnBefore
            // 
            btnBefore.BackColor = Color.FromArgb(219, 184, 142);
            btnBefore.Cursor = Cursors.Hand;
            btnBefore.FlatAppearance.BorderSize = 0;
            btnBefore.FlatStyle = FlatStyle.Flat;
            btnBefore.ForeColor = SystemColors.ButtonHighlight;
            btnBefore.Location = new Point(512, 627);
            btnBefore.Name = "btnBefore";
            btnBefore.Size = new Size(58, 29);
            btnBefore.TabIndex = 13;
            btnBefore.Text = "Trước";
            btnBefore.UseVisualStyleBackColor = false;
            btnBefore.Click += btnBefore_Click_1;
            // 
            // listBillInfo
            // 
            listBillInfo.FullRowSelect = true;
            listBillInfo.GridLines = true;
            listBillInfo.Location = new Point(724, 121);
            listBillInfo.Name = "listBillInfo";
            listBillInfo.Size = new Size(297, 490);
            listBillInfo.TabIndex = 16;
            listBillInfo.UseCompatibleStateImageBehavior = false;
            listBillInfo.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(219, 184, 142);
            label1.Location = new Point(724, 75);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 17;
            label1.Text = "Thông tin hóa đơn";
            // 
            // btnExportBill
            // 
            btnExportBill.BackColor = Color.FromArgb(219, 184, 142);
            btnExportBill.Cursor = Cursors.Hand;
            btnExportBill.FlatAppearance.BorderSize = 0;
            btnExportBill.FlatStyle = FlatStyle.Flat;
            btnExportBill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportBill.ForeColor = SystemColors.ButtonHighlight;
            btnExportBill.Location = new Point(921, 69);
            btnExportBill.Name = "btnExportBill";
            btnExportBill.Size = new Size(100, 40);
            btnExportBill.TabIndex = 18;
            btnExportBill.Text = "In hóa đơn";
            btnExportBill.UseVisualStyleBackColor = false;
            btnExportBill.Click += btnExportBill_Click;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 650);
            Controls.Add(btnExportBill);
            Controls.Add(label1);
            Controls.Add(listBillInfo);
            Controls.Add(Page);
            Controls.Add(btnNext);
            Controls.Add(btnBefore);
            Controls.Add(btnThongke);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(dateEnd);
            Controls.Add(dateStart);
            Controls.Add(flpListTable);
            Name = "Invoice";
            Text = "Invoice";
            Load += Invoice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpListTable;
        private Button btnThongke;
        private Label label21;
        private Label label20;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Label Page;
        private Button btnNext;
        private Button btnBefore;
        private ListView listBillInfo;
        private Label label1;
        private Button btnExportBill;
    }
}