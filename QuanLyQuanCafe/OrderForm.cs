using Microsoft.Office.Interop.Excel;
using QuanLyQuanCafe.DAO;
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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            SetRoundedRichTextBox(richTextBox1, 20);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            SetRoundedButton(btnAddFood, 10);
            SetRoundedButton(btnChuyenBan, 10);
            SetRoundedButton(btnThanhToan, 10);
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
        private void SetRoundedRichTextBox(RichTextBox richTextBox, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Góc trên bên trái
            path.AddLine(radius, 0, richTextBox.Width - radius, 0); // Đoạn thẳng trên
            path.AddArc(richTextBox.Width - radius, 0, radius, radius, 270, 90); // Góc trên bên phải
            path.AddLine(richTextBox.Width, radius, richTextBox.Width, richTextBox.Height - radius); // Đoạn thẳng bên phải
            path.AddArc(richTextBox.Width - radius, richTextBox.Height - radius, radius, radius, 0, 90); // Góc dưới bên phải
            path.AddLine(richTextBox.Width - radius, richTextBox.Height, radius, richTextBox.Height); // Đoạn thẳng dưới
            path.AddArc(0, richTextBox.Height - radius, radius, radius, 90, 90); // Góc dưới bên trái
            path.AddLine(0, richTextBox.Height - radius, 0, radius); // Đoạn thẳng bên trái
            path.CloseFigure();
            richTextBox.Region = new Region(path); // Áp dụng hình dạng vào RichTextBox
        }


        int idTable = 0;
        public void loadTable(int id, string TableName)
        {
            flpListTable.Controls.Clear();
            List<TableDTO> listTable = TableDAO.getAllTableByRoomAndName(id, txtTable.Text);

            foreach (var item in listTable)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button { Width = TableDAO.TableWidth - 20, Height = TableDAO.TableHeight - 20 };
                BillDTO checkBill = BillDAO.checkBillByTable(item.TableID);
                
                if (checkBill != null)
                {
                    btn.BackColor = Color.FromArgb(128, 247, 113);
                    
                    btn.Text = item.TableName + Environment.NewLine + "\n" + "Đã có người";
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.Text = item.TableName + Environment.NewLine + "\n" + "Trống";
                }
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

        public void TotalBill(float total)
        {
            richTextBox1.Text = total.ToString() + " đ";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        int BillClickID = 0;
        TableDTO tableClick = null;
        public void loadListview(int billID)
        {
            listViewBill.Items.Clear();
            listViewBill.Columns.Clear();
            listViewBill.DataBindings.Clear();
            listViewBill.Columns.Add("Tên đồ ăn", 140);
            listViewBill.Columns.Add("Giá tiền", 120);
            listViewBill.Columns.Add("Số lượng", 50);
            listViewBill.Columns.Add("Tổng tiền", 100);
            float total = 0;
            List<BillInfoDTO> listBill = BillInfoDAO.getAllBillInfoByID(billID);
            foreach (BillInfoDTO billInfo in listBill)
            {
                FoodDTO food = FoodDAO.getFoodByID(billInfo.FoodID);
                ListViewItem item = new ListViewItem();
                item.Text = food.FoodName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.FoodPrice.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = billInfo.Quantity.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (food.FoodPrice * billInfo.Quantity).ToString() });
                total += food.FoodPrice * billInfo.Quantity;
                listViewBill.Items.Add(item);
            }
            ListViewItem itemTotal = new ListViewItem();
            itemTotal.Text = "Total";
            itemTotal.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            itemTotal.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            itemTotal.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = total.ToString() });
            listViewBill.Items.Add(itemTotal);
            TotalBill(total);
            BillClickID = billID;
        }
        private void btn_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            if (clickedButton != null)
            {
                int index = int.Parse(clickedButton.Name);
                idTable = index;
                TableDTO table = clickedButton.Tag as TableDTO;
                tableClick = table;
                if (table != null)
                {
                    BillDTO checkBill = BillDAO.checkBillByTable(table.TableID);
                    if (checkBill != null)
                    {
                        loadListview(checkBill.BillID);
                    }
                    else
                    {
                        listViewBill.Items.Clear();
                        listViewBill.DataBindings.Clear();
                        listViewBill.Columns.Add("Tên đồ ăn", 140);
                        listViewBill.Columns.Add("Giá tiền", 120);
                        listViewBill.Columns.Add("Số lượng", 50);
                        listViewBill.Columns.Add("Tổng tiền", 100);
                        TotalBill(0);
                        BillClickID = 0;
                    }
                }

            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            cbRoom.DataSource = TableDAO.getAllRoomName();
            cbDoiRoom.DataSource = TableDAO.getAllRoomName();
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

        public void exportBill()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel worbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Tên đồ ăn";
                    ws.Cells[1, 2] = "Giá tiền";
                    ws.Cells[1, 3] = "Số lượng";
                    ws.Cells[1, 4] = "Tổng tiền";
                    int i = 2;
                    foreach (ListViewItem item in listViewBill.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("In hóa đơn thành công", "Thông báo");
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (BillClickID == 0)
            {
                MessageBox.Show("Bàn trống hoặc chưa chọn bàn", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn không?", "Xác nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    exportBill();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Thanh toán thành công", "Thông báo");
                }
                bool check = BillDAO.thanhToan(BillClickID);
                check = BillDAO.tinhTotal(BillClickID);
                int id = BillDAO.getBillByTable(idTable);
                loadListview(id);
                loadTable(TableDAO.getRoomByName(cbRoom.Text), txtTable.Text);

            }
        }

        private void listViewBill_DoubleClick(object sender, EventArgs e)
        {
            if (listViewBill.SelectedItems.Count > 0)
            {
                string data = listViewBill.SelectedItems[0].SubItems[0].Text;
                UpdateFoodInBill updateFoodInBill = new UpdateFoodInBill(data, BillClickID);
                updateFoodInBill.Show();
                updateFoodInBill.FormClosed += updateFoodInBill_FormClosed;
            }
        }

        private void updateFoodInBill_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadListview(BillClickID);
            List<BillInfoDTO> billInfoDTOs = BillInfoDAO.getAllBillInfoByID(BillClickID);
            if (billInfoDTOs.Count < 1)
            {
                bool check = BillDAO.deleteBill(BillClickID);
                loadTable(TableDAO.getRoomByName(cbRoom.Text), txtTable.Text);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (tableClick != null)
            {
                ListFood listFood = new ListFood(tableClick);
                listFood.FormClosed += ListFood_FormClosed;
                listFood.Show();    
            }
        }

        private void ListFood_FormClosed(object? sender, FormClosedEventArgs e)
        {
            int id = BillDAO.getBillByTable(idTable);
            loadListview(id);
            loadTable(TableDAO.getRoomByName(cbRoom.Text), txtTable.Text);
        }
    }
}
