using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyQuanCafe.Form1;

namespace QuanLyQuanCafe
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void resetColor()
        {
            panelGoiDo.BackColor = Color.FromArgb(219, 184, 142);
            panelHoaDon.BackColor = Color.FromArgb(219, 184, 142);
            panelProfile.BackColor = Color.FromArgb(219, 184, 142);
            panelForManager.BackColor = Color.FromArgb(219, 184, 142);
            btnManager.BackColor = Color.FromArgb(219, 184, 142);
            btnGoiDo.BackColor = Color.FromArgb(219, 184, 142);
            btnHoadon.BackColor = Color.FromArgb(219, 184, 142);
            btnProfile.BackColor = Color.FromArgb(219, 184, 142);
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            resetColor();
        }

        private void btnGoiDo_Click(object sender, EventArgs e)
        {
            resetColor();
            panelGoiDo.BackColor = Color.FromArgb(116, 76, 31);
            btnGoiDo.BackColor = Color.FromArgb(116, 76, 31);
            panelManager.Controls.Clear();
            OrderForm orderForm = new OrderForm();
            orderForm.TopLevel = false;
            this.panelManager.Controls.Add(orderForm);
            orderForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            orderForm.Dock = DockStyle.Fill;
            orderForm.Show();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            resetColor();
            panelHoaDon.BackColor = Color.FromArgb(116, 76, 31);
            btnHoadon.BackColor = Color.FromArgb(116, 76, 31);
            panelManager.Controls.Clear();
            Invoice invoice = new Invoice();
            invoice.TopLevel = false;
            this.panelManager.Controls.Add(invoice);
            invoice.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            invoice.Dock = DockStyle.Fill;
            invoice.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            resetColor();
            panelProfile.BackColor = Color.FromArgb(116, 76, 31);
            btnProfile.BackColor = Color.FromArgb(116, 76, 31);
            panelManager.Controls.Clear();
            ProfileForm profileForm = new ProfileForm();
            profileForm.TopLevel = false;
            this.panelManager.Controls.Add(profileForm);
            profileForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            profileForm.Dock = DockStyle.Fill;
            profileForm.Show();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManager_Click(object sender, EventArgs e)
        {

            resetColor();
            panelForManager.BackColor = Color.FromArgb(116, 76, 31);
            btnManager.BackColor = Color.FromArgb(116, 76, 31);
            if (Account.account.Role == 0)
            {
                TableManager tableManager = new TableManager();
                panelManager.Controls.Clear();
                tableManager.Show();
            }
            else
            {
                panelManager.Controls.Clear();
                MessageBox.Show("Đăng nhập tài khoản admin để thực hiện chức năng này", "Thông báo");
            }
        }
    }
}
