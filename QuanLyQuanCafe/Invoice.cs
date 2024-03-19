using Microsoft.Office.Interop.Excel;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyQuanCafe.Form1;

namespace QuanLyQuanCafe
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();

        }

        int PageNow = 1;
        public void loadInvoice()
        {
            Page.Text = "" + PageNow + "/" + countPage();
            flpListTable.Controls.Clear();

            System.Windows.Forms.Button btnContent = new System.Windows.Forms.Button();
            btnContent.Margin = new Padding(10, 10, btnContent.Margin.Right, btnContent.Margin.Bottom);
            btnContent.Size = new Size(650, 35);
            btnContent.Cursor = Cursors.Hand;
            btnContent.FlatStyle = FlatStyle.Flat;
            btnContent.FlatAppearance.BorderSize = 0;
            btnContent.BackColor = Color.FromArgb(239, 226, 211);
            System.Windows.Forms.Label content1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label content2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label content3 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label content4 = new System.Windows.Forms.Label();
            content1.AutoSize = true; // Auto size the label based on its contents
            content1.Font = new System.Drawing.Font(btnContent.Font.FontFamily, 10, FontStyle.Bold);
            content1.Text = "TimeCheckIn";
            int labelYx = (btnContent.Height - content1.Height) / 2;
            content1.Location = new System.Drawing.Point(20, labelYx);
            btnContent.Controls.Add(content1);


            content2.AutoSize = true; // Auto size the label based on its contents
            content2.Font = new System.Drawing.Font(btnContent.Font.FontFamily, 10, FontStyle.Bold);
            content2.Text = "TimeCheckOut";
            content2.Location = new System.Drawing.Point(220, labelYx);
            btnContent.Controls.Add(content2);

            content3.AutoSize = true; // Auto size the label based on its contents
            content3.Font = new System.Drawing.Font(btnContent.Font.FontFamily, 10, FontStyle.Bold);
            content3.Text = "TableID";
            content3.Location = new System.Drawing.Point(410, labelYx);
            btnContent.Controls.Add(content3);

            content4.AutoSize = true; // Auto size the label based on its contents
            content4.Font = new System.Drawing.Font(btnContent.Font.FontFamily, 10, FontStyle.Bold);
            content4.Text = "Total";
            content4.Location = new System.Drawing.Point(525, labelYx);
            btnContent.Controls.Add(content4);
            flpListTable.Controls.Add(btnContent);

            List<BillDTO> listBill = BillDAO.getAllBillByDayEachEmployee(dateStart.Text, dateEnd.Text, PageNow, Account.account.Id);
            for (int i = 0; i < listBill.Count; i++)
            {
                System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                button.Margin = new Padding(10, 20, button.Margin.Right, button.Margin.Bottom);
                button.Size = new Size(650, 70);
                button.Cursor = Cursors.Hand;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = Color.White;
                button.Click += button_Click;
                button.Name = "" + listBill[i].BillID;
                System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
                System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
                System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
                System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
                label2.AutoSize = true; // Auto size the label based on its contents
                label2.Font = new System.Drawing.Font(button.Font.FontFamily, 9, FontStyle.Regular);
                label2.Text = listBill[i].TimeCheckIn.ToString();
                int labelY = (button.Height - label2.Height) / 2;
                label2.Location = new System.Drawing.Point(20, labelY);

                label3.AutoSize = true; // Auto size the label based on its contents
                label3.Font = new System.Drawing.Font(button.Font.FontFamily, 9, FontStyle.Regular);
                label3.Text = listBill[i].TimeCheckOut.ToString();
                label3.Location = new System.Drawing.Point(220, labelY);
                button.Controls.Add(label2);
                button.Controls.Add(label3);

                label4.AutoSize = true; // Auto size the label based on its contents
                label4.Font = new System.Drawing.Font(button.Font.FontFamily, 9, FontStyle.Regular);
                label4.Text = listBill[i].TableID.ToString();
                label4.Location = new System.Drawing.Point(430, labelY);
                button.Controls.Add(label4);

                label5.AutoSize = true; // Auto size the label based on its contents
                label5.Font = new System.Drawing.Font(button.Font.FontFamily, 9, FontStyle.Regular);
                label5.Text = listBill[i].Total.ToString() + "đ";
                label5.Location = new System.Drawing.Point(530, labelY);
                button.Controls.Add(label5);
                SetRoundedButton(button, 15);
                flpListTable.Controls.Add(button);
            }
        }

        private void button_Click(object? sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null)
            {
                int index = int.Parse(button.Name);
                loadListBillInfo(index);
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {

            loadInvoice();
            SetRoundedButton(btnThongke, 15);
            SetRoundedButton(btnNext, 15);
            SetRoundedButton(btnBefore, 15);
            SetRoundedButton(btnExportBill, 15);
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

        private void btnThongke_Click(object sender, EventArgs e)
        {
            loadInvoice();
        }

        public int countPage()
        {
            int countPage = 0;
            int count = BillDAO.countBillByDayEmployee(dateStart.Text, dateEnd.Text, Account.account.Id);
            if (count > 0)
            {
                if (count % 10 == 0) { countPage = count / 10; }
                else { countPage = count / 10 + 1; }
            }
            return countPage;
        }





        private void btnBefore_Click_1(object sender, EventArgs e)
        {
            if (PageNow > 1)
            {
                PageNow--;
                loadInvoice();
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            int pageEnd = countPage();
            if (PageNow < pageEnd)
            {
                PageNow++;
                loadInvoice();
            }
        }


        public void loadListBillInfo(int BillID)
        {
            listBillInfo.Items.Clear();
            listBillInfo.Columns.Clear();
            listBillInfo.DataBindings.Clear();
            listBillInfo.Columns.Add("Tên đồ ăn", 100);
            listBillInfo.Columns.Add("Giá tiền", 70);
            listBillInfo.Columns.Add("Số lượng", 50);
            listBillInfo.Columns.Add("Tổng tiền", 90);
            float total = 0;
            List<BillInfoDTO> listBill = BillInfoDAO.getAllBillInfoByID(BillID);
            foreach (BillInfoDTO billInfo in listBill)
            {
                FoodDTO food = FoodDAO.getFoodByID(billInfo.FoodID);
                ListViewItem item = new ListViewItem();
                item.Text = food.FoodName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.FoodPrice.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = billInfo.Quantity.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (food.FoodPrice * billInfo.Quantity).ToString() });
                total += food.FoodPrice * billInfo.Quantity;
                listBillInfo.Items.Add(item);
            }
            ListViewItem itemTotal = new ListViewItem();
            itemTotal.Text = "Total";
            itemTotal.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            itemTotal.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            itemTotal.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = total.ToString() });
            listBillInfo.Items.Add(itemTotal);

        }

        private void btnExportBill_Click(object sender, EventArgs e)
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
                    foreach (ListViewItem item in listBillInfo.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("In thành công");
                }
            }
        }
    }
}
