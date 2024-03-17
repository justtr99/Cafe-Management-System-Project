using QuanLyQuanCafe.Models;
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
    public partial class ListFood : Form
    {
        TableDTO table = new TableDTO();
        public ListFood()
        {
            InitializeComponent();
        }
        public ListFood(TableDTO table)
        {
            InitializeComponent();
            this.table = table;
        }

    }
}
