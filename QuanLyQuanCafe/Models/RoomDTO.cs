using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Models
{
    public class RoomDTO
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }

        public RoomDTO(int roomID, string roomName)
        {
            RoomID = roomID;
            RoomName = roomName;
        }

        public RoomDTO()
        {
        }
    }
}
