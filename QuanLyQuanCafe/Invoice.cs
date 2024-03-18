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

            Button btnContent = new Button();
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
            content1.Location = new Point(20, labelYx);
            btnContent.Controls.Add(content1);


            content2.AutoSize = true; // Auto size the label based on its contents
            content2.Font = new System.Drawing.Font(btnContent.Font.FontFamily, 10, FontStyle.Bold);
            content2.Text = "TimeCheckOut";
            content2.Location = new Point(220, labelYx);
            btnContent.Controls.Add(content2);

            content3.AutoSize = true; // Auto size the label based on its contents
            content3.Font = new System.Drawing.Font(btnContent.Font.FontFamily, 10, FontStyle.Bold);
            content3.Text = "TableID";
            content3.Location = new Point(410, labelYx);
            btnContent.Controls.Add(content3);

            content4.AutoSize = true; // Auto size the label based on its contents
            content4.Font = new System.Drawing.Font(btnContent.Font.FontFamily, 10, FontStyle.Bold);
            content4.Text = "Total";
            content4.Location = new Point(525, labelYx);
            btnContent.Controls.Add(content4);
            flpListTable.Controls.Add(btnContent);

            List<BillDTO> listBill = BillDAO.getAllBillByDayEachEmployee(dateStart.Text, dateEnd.Text, PageNow, Account.account.Id);
            for (int i = 0; i < listBill.Count; i++)
            {
                Button button = new Button();
                button.Margin = new Padding(10, 20, button.Margin.Right, button.Margin.Bottom);
                button.Size = new Size(650, 70);
                button.Cursor = Cursors.Hand;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = Color.White;
                System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
                System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
                System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
                System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
                label2.AutoSize = true; // Auto size the label based on its contents
                label2.Font = new System.Drawing.Font(button.Font.FontFamily, 9, FontStyle.Regular);
                label2.Text = listBill[i].TimeCheckIn.ToString();
                int labelY = (button.Height - label2.Height) / 2;
                label2.Location = new Point(20, labelY);

                label3.AutoSize = true; // Auto size the label based on its contents
                label3.Font = new System.Drawing.Font(button.Font.FontFamily, 9, FontStyle.Regular);
                label3.Text = listBill[i].TimeCheckOut.ToString();
                label3.Location = new Point(220, labelY);
                button.Controls.Add(label2);
                button.Controls.Add(label3);

                label4.AutoSize = true; // Auto size the label based on its contents
                label4.Font = new System.Drawing.Font(button.Font.FontFamily, 9, FontStyle.Regular);
                label4.Text = listBill[i].TableID.ToString();
                label4.Location = new Point(430, labelY);
                button.Controls.Add(label4);

                label5.AutoSize = true; // Auto size the label based on its contents
                label5.Font = new System.Drawing.Font(button.Font.FontFamily, 9, FontStyle.Regular);
                label5.Text = listBill[i].Total.ToString() + "đ";
                label5.Location = new Point(530, labelY);
                button.Controls.Add(label5);
                SetRoundedButton(button, 15);
                flpListTable.Controls.Add(button);
            }
        }
        private void Invoice_Load(object sender, EventArgs e)
        {

            loadInvoice();
            SetRoundedButton(btnThongke, 15);
            SetRoundedButton(btnNext, 15);
            SetRoundedButton(btnBefore, 15);
        }

        private void SetRoundedButton(Button button, int radius)
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
    }
}
