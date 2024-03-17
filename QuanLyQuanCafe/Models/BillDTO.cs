using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Models
{
    public class BillDTO
    {
        public DateTime TimeCheckIn { get; set; }   
        public DateTime TimeCheckOut { get; set;}
        public int TableID { get; set; }
        public int TakeAwayID { get; set; }
        public string CreateBy { get; set; }
        public float Total {  get; set; }
        public string BillStatus { get; set; }
        public int AccountID { get; set; }
        public int BillID { get; set; }
        public BillDTO(int billID, DateTime timeCheckIn, DateTime timeCheckOut, int tableID, string billStatus, int accountID)
        {
            BillID = billID;
            TimeCheckIn = timeCheckIn;
            TimeCheckOut = timeCheckOut;
            TableID = tableID;
            BillStatus = billStatus;
            AccountID = accountID;
        }       
        public BillDTO() { }
    }
}
