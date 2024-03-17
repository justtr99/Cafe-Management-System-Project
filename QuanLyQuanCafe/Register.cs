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

namespace QuanLyQuanCafe
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int countError = 0;
                errorName.Text = "";
                errorPassword.Text = "";
                errorPhone.Text = "";
                errorReEnterPass.Text = "";
                errorUsername.Text = "";
                errorTotal.Text = "";
                if (txtFullName.Text.Length == 0)
                {
                    errorName.Text = "Không được để trống";
                }

                if (txtPassword.Text.Length == 0)
                {
                    errorPassword.Text = "Không được để trống";
                }
                if (txtPhone.Text.Length != 10)
                {
                    errorPhone.Text = "Sđt không hợp lệ";
                }
                try
                {
                    int a = int.Parse(txtPhone.Text);
                    countError = 1;
                }catch (Exception)
                {
                    errorPhone.Text = "Sđt không hợp lệ";
                }
                if (txtReEnterPass.Text.Length == 0)
                {
                    errorReEnterPass.Text = "Không được để trống";
                }
                if (txtUsername.Text.Length == 0)
                {
                    errorUsername.Text = "Không được để trống";
                }
                if (countError==1&&txtFullName.Text.Length > 0 && txtPassword.Text.Length > 0 && txtPhone.Text.Length == 10 && txtReEnterPass.Text.Length > 0 && txtUsername.Text.Length > 0)
                {
                    if (txtPassword.Text.Equals(txtReEnterPass.Text))
                    {
                        bool check = AccountDAO.insertAccount(txtUsername.Text, txtPassword.Text, txtFullName.Text, txtPhone.Text);
                        if (check)
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }
                    else
                    {
                        errorTotal.Text = "Mật khẩu nhập lại không khớp";
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Username hoặc sđt đã tồn tại vui lòng nhập lại");
            }
        }
    }
}
