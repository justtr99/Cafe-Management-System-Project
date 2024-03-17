using QuanLyCafe.Models;
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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            SetRoundedButton(btnProfile, 10);
            SetRoundedButton(btnLogout, 10);
            SetRoundedButton(btnChangePass, 10);

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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile();
            viewProfile.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form formToClose = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.Name == "HomePage");
            if (formToClose != null)
            {
                Account.account = new AccountDTO(); 
                formToClose.Close();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {

            ChangePass changePass = new ChangePass();
            changePass.Show();
        }
    }
}
