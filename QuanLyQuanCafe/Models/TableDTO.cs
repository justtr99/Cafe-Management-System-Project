using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Models
{
    public class TableDTO
    {
        public int TableID { get; set; }
        public string TableName { get; set; }
        public string TableStatus { get; set; }

        public int RoomID { get; set; }

        public TableDTO(int tableID, string tableName, string tableStatus, int roomID)
        {
            TableID = tableID;
            TableName = tableName;
            TableStatus = tableStatus;
            RoomID = roomID;
        }

        public TableDTO()
        {
        }
    }
}
