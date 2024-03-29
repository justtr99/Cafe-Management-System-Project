﻿using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.Models;
using QuanLyQuanCafe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class ChangeTable : Form
    {
        int tableiD = 0;
        public ChangeTable()
        {
            InitializeComponent();
        }

        public ChangeTable(int tableId)
        {
            InitializeComponent();
            this.tableiD = tableId;

        }


        private void SetRoundedButton(System.Windows.Forms.Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Góc trên bên trái
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90); // Góc trên bên phải
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90); // Góc dưới bên phải
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90); // Góc dưới bên trái
            path.CloseFigure();
            button.Region = new Region(path); // Áp dụng hình dạng vào nút
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void loadTable(int id, string TableName)
        {
            flpListTable.Controls.Clear();
            List<TableDTO> listTable = TableDAO.getAllTableByRoomAndName(id, txtTable.Text);

            foreach (var item in listTable)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button { Width = TableDAO.TableWidth - 20, Height = TableDAO.TableHeight - 20 };
                BillDTO checkBill = BillDAO.checkBillByTable(item.TableID);

                if (checkBill == null)
                {
                    btn.BackColor = Color.White;
                    btn.Text = item.TableName + Environment.NewLine + "\n" + "Trống";
                    btn.Cursor = Cursors.Hand;
                    btn.Click += btn_Click;
                    btn.BackgroundImageLayout = ImageLayout.Zoom;
                    btn.BackgroundImage = Resources.dining_table__2_;
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.Tag = item;
                    btn.Name = item.TableID.ToString();
                    btn.Font = new System.Drawing.Font(btn.Font.FontFamily, 10, FontStyle.Bold);
                    flpListTable.Controls.Add(btn);
                }


            }

        }
        int newTableID = 0;
        private void btn_Click(object? sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            if (clickedButton != null)
            {
                int index = int.Parse(clickedButton.Name);
                newTableID = index;
            }
        }

        private void ChangeTable_Load(object sender, EventArgs e)
        {
            SetRoundedButton(btnChangeTable, 10);
            cbRoom.DataSource = TableDAO.getAllRoomName();
            loadTable(TableDAO.getRoomByName(cbRoom.Text), txtTable.Text);
        }

        private void cbRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            loadTable(TableDAO.getRoomByName(cbRoom.Text), txtTable.Text);
        }

        private void txtTable_TextChanged(object sender, EventArgs e)
        {
            loadTable(TableDAO.getRoomByName(cbRoom.Text), txtTable.Text);
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            if(newTableID > 0 && tableiD >0)
            {
                bool check = BillDAO.changeTable(tableiD,newTableID);
                if(check)
                {
                    MessageBox.Show("Đổi bàn thành công","Thông báo");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bàn", "Thông báo");
            }
        }
    }
}
