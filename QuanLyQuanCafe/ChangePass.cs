using QuanLyCafe.DAO;
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
using static QuanLyQuanCafe.Form1;

namespace QuanLyQuanCafe
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
            SetRoundedButton(btnSave, 10);
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

        public void resetPass()
        {
            errorEnterAgain.Text = "";
            errorOldPass.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            resetPass();
            try
            {
                if (textNewPass.Text.Equals(textEnterAgain.Text))
                {
                    bool check = AccountDAO.updatePass(Account.account.Id, textOldPass.Text, textNewPass.Text);
                    if (check)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                    }
                    else errorOldPass.Text = "Mật khẩu không đúng";
                }
                else errorEnterAgain.Text = "Mật khẩu nhập lại không đúng";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
