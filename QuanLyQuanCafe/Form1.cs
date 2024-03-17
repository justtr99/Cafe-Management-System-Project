using QuanLyCafe.DAO;
using QuanLyCafe.Models;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.Http;
using static QuanLyQuanCafe.Form1;

namespace QuanLyQuanCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetRoundedButton(btnLogin, 10);


        }

        public class Account
        {
            public static AccountDTO account = new AccountDTO(); 
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountDTO accountDTO = AccountDAO.getAccount(btnUsername.Text, btnPassword.Text);
            if (accountDTO != null)
            {
                HomePage home = new HomePage();
                Account.account = accountDTO; 
                this.Hide();
                home.Show();
                home.FormClosed += HomePage_FormClosed; // Gắn sự kiện khi form tableManager đóng
               
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo");
        }
        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(this.ActiveMdiChild is HomePage))
            {
                Account.account = new AccountDTO();
                this.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
