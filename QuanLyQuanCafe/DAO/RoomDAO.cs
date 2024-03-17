using QuanLyCafe.Del;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class RoomDAO
    {
        public static bool insertRoom(string name)
        {
            string sql = "insert into Room "
                + "values (@RoomName)";
            SqlParameter parameter1 = new SqlParameter("@RoomName", DbType.String);
            parameter1.Value = name;
            int count = DBContext.ExecuteBySql(sql, parameter1);
            if (count > 0) { return true; }
            return false;

        }
        
        public static bool deleteRoom(string name)
        {
            string sql = "delete  Room where RoomName = @name";
            SqlParameter parameter1 = new SqlParameter("@name", DbType.String);
            parameter1.Value = name;
            int count = DBContext.ExecuteBySql(sql, parameter1);
            if (count > 0) { return true; }
            return false;
        }
        public static string getRoomByID(int ID)
        {
            string RoomName = "";
            string sql = "select RoomName from Room where RoomID = @RoomID";
            SqlParameter parameter1 = new SqlParameter("@RoomID", DbType.Int32);
            parameter1.Value = ID;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1);
            foreach (DataRow dr in dt.Rows) {
                RoomName = dr["RoomName"].ToString();
            }
            return RoomName;
        }
    }
}
