﻿namespace QuanLyQuanCafe
{
    partial class ListFood
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtFoodName = new TextBox();
            cbType = new ComboBox();
            listViewOrder = new ListView();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(28, 165);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(723, 456);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 114);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 2;
            label2.Text = "Loại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(448, 9);
            label3.Name = "label3";
            label3.Size = new Size(303, 41);
            label3.TabIndex = 3;
            label3.Text = "Danh sách mặt hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 70);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 4;
            label1.Text = "Tên đồ ăn:";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(141, 74);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(210, 27);
            txtFoodName.TabIndex = 5;
            txtFoodName.TextChanged += txtFoodName_TextChanged;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Tất cả", "Đồ ăn", "Đồ uống" });
            cbType.Location = new Point(141, 118);
            cbType.Name = "cbType";
            cbType.Size = new Size(210, 28);
            cbType.TabIndex = 6;
            cbType.SelectedValueChanged += cbType_SelectedValueChanged;
            // 
            // listViewOrder
            // 
            listViewOrder.GridLines = true;
            listViewOrder.Location = new Point(763, 165);
            listViewOrder.Name = "listViewOrder";
            listViewOrder.Size = new Size(374, 412);
            listViewOrder.TabIndex = 7;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = View.Details;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(896, 583);
            button1.Name = "button1";
            button1.Size = new Size(137, 38);
            button1.TabIndex = 8;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(757, 122);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 9;
            label4.Text = "Danh sách order";
            // 
            // ListFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 184, 142);
            ClientSize = new Size(1149, 633);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(listViewOrder);
            Controls.Add(cbType);
            Controls.Add(txtFoodName);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "ListFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListFood";
            Load += ListFood_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtFoodName;
        private ComboBox cbType;
        private ListView listViewOrder;
        private Button button1;
        private Label label4;
    }
}