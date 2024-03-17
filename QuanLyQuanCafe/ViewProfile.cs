using QuanLyCafe.Models;
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
    public partial class ViewProfile : Form
    {
        public ViewProfile()
        {
            InitializeComponent();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            lebelFullName.Text = Account.account.Name;
            labelUsername.Text = Account.account.Username;
            labelSdt.Text = Account.account.Phone;
        }
    }
}
