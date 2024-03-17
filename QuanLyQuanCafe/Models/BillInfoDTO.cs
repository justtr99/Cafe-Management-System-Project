using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Models
{
    public class BillInfoDTO
    {
        public int BillInfoID { get; set; }
        public int BillID { get; set; } 
        public int FoodID { get; set; }
        
        public int Quantity { get; set; }

        public BillInfoDTO(int billInfoID, int billID, int foodID, int quantity)
        {
            BillInfoID = billInfoID;
            BillID = billID;
            FoodID = foodID;
            Quantity = quantity;
        }

        public BillInfoDTO()
        {
        }
    }
}
