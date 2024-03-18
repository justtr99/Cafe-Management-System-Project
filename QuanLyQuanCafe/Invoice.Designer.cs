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
            SuspendLayout();
            // 
            // flpListTable
            // 
            flpListTable.AutoScroll = true;
            flpListTable.BackColor = Color.FromArgb(239, 226, 211);
            flpListTable.Location = new Point(12, 75);
            flpListTable.Name = "flpListTable";
            flpListTable.Size = new Size(695, 536);
            flpListTable.TabIndex = 1;
            // 
            // btnThongke
            // 
            btnThongke.BackColor = Color.FromArgb(219, 184, 142);
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
            label20.Location = new Point(12, 26);
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
            dateStart.Location = new Point(95, 25);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(127, 27);
            dateStart.TabIndex = 7;
            // 
            // Page
            // 
            Page.AutoSize = true;
            Page.BackColor = Color.Gray;
            Page.ForeColor = SystemColors.ButtonHighlight;
            Page.Location = new Point(581, 632);
            Page.Name = "Page";
            Page.Size = new Size(31, 20);
            Page.TabIndex = 15;
            Page.Text = "0/0";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(624, 628);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(58, 29);
            btnNext.TabIndex = 14;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBefore
            // 
            btnBefore.Location = new Point(512, 628);
            btnBefore.Name = "btnBefore";
            btnBefore.Size = new Size(58, 29);
            btnBefore.TabIndex = 13;
            btnBefore.Text = "Trước";
            btnBefore.UseVisualStyleBackColor = true;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 650);
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
    }
}