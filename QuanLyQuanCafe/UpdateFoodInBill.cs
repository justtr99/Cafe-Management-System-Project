using QuanLyQuanCafe.DAO;
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
    public partial class UpdateFoodInBill : Form
    {
        private string FoodName;
        private int BillInfoID;
        public UpdateFoodInBill()
        {
            InitializeComponent();
        }

        public UpdateFoodInBill(string data, int BillInfoID)
        {
            InitializeComponent();
            this.FoodName = data;
            this.BillInfoID = BillInfoID;
        }

        private void UpdateFoodInBill_Load(object sender, EventArgs e)
        {
            if (FoodName != null)
            {
                int id = FoodDAO.getFoodIDByName(FoodName);
                if (id > 0)
                {
                    labelFoodName.Text = FoodName;
                    BillInfoDTO billInfo = BillInfoDAO.GetBillInfoByTableAndFood(BillInfoID, id);
                    numerQuatity.Value = billInfo.Quantity;
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = FoodDAO.getFoodIDByName(FoodName);
            bool check = BillInfoDAO.updateBillInfo(int.Parse(numerQuatity.Value.ToString()), BillInfoID, id);
            if (check) { MessageBox.Show("Sửa thành công", "Thông báo"); this.Close(); }
            else MessageBox.Show("Sửa thất bại", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = FoodDAO.getFoodIDByName(FoodName);
            bool check = BillInfoDAO.deleteBiffInfo(BillInfoID, id);
            if (check) 
            { 
                MessageBox.Show("Xóa thành công", "Thông báo"); this.Close();
                
            }
            else MessageBox.Show("Xóa thất bại", "Thông báo");
        }
    }
}
