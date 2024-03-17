using QuanLyCafe.Del;
using QuanLyQuanCafe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        public static int TableWidth = 164;
        public static int TableHeight = 164;
        public static TableDTO getTableByRoomAndName(int RoomID,string name)
        {
            TableDTO table = null;
            string sql = "select * from [Table] where RoomID = @RoomID and TableName like @name";
            SqlParameter parameter1 = new SqlParameter("@RoomID", DbType.Int32),
                parameter2 = new SqlParameter("@name", DbType.String);
            parameter1.Value = RoomID;
            parameter2.Value = "%" + name + "%";
            DataTable dt = DBContext.GetDataBySql(sql,parameter1,parameter2);
            foreach (DataRow dr in dt.Rows)
            {
               table =  new TableDTO(int.Parse(dr["TableID"].ToString()), dr["TableName"].ToString(), dr["TableStatus"].ToString(), int.Parse(dr["RoomID"].ToString()));
            }

            return table;
        }
        public static List<TableDTO> getAllTableByRoomAndName(int RoomID, string name)
        {
            List<TableDTO> list = new List<TableDTO>();
            string sql = "select * from [Table] where RoomID = @RoomID and TableName like @name";
            SqlParameter parameter1 = new SqlParameter("@RoomID", DbType.Int32),
                parameter2 = new SqlParameter("@name", DbType.String);
            parameter1.Value = RoomID;
            parameter2.Value = "%" + name + "%";
            DataTable dt = DBContext.GetDataBySql(sql, parameter1, parameter2);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new TableDTO(int.Parse(dr["TableID"].ToString()), dr["TableName"].ToString(), dr["TableStatus"].ToString(), int.Parse(dr["RoomID"].ToString())));
            }

            return list;
        }
        public static List<string> getAllRoomName()
        {
            List<string> listName = new List<string>();
            string sql = "select RoomName from Room";
            DataTable dt = DBContext.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                listName.Add(dr["RoomName"].ToString());
            }

            return listName;
        }
        public static int getRoomByName(string RoomName)
        {
            int id = 0;
            string sql = "select RoomID from Room where RoomName = @RoomName";
            SqlParameter parameter1 = new SqlParameter("@RoomName", DbType.String);
            parameter1.Value = RoomName;
            DataTable dt = DBContext.GetDataBySql(sql,parameter1);
            foreach (DataRow dr in dt.Rows)
            {
                id = int.Parse(dr["RoomID"].ToString());
            }
            return id;
        }
        public static bool insertTable(string TableName,int RoomID)
        {
            string sql = "insert into [Table] (TableName,RoomID) "
                + "values (@TableName,@RoomID)";
            SqlParameter parameter1 = new SqlParameter("@TableName", DbType.String),
                parameter2 = new SqlParameter("@RoomID",DbType.Int32);
            parameter1.Value = TableName;
            parameter2.Value = RoomID;
            int count = DBContext.ExecuteBySql(sql,parameter1,parameter2);
            if (count > 0) { return true; }
            return false;
        }
        public static bool updateTable(string TableName,int RoomID,string NewName)
        {
            string sql = "update [Table] "
                + "set TableName = @NewName "
                + "where TableName = @TableName and RoomID = @RoomID";
            SqlParameter parameter1 = new SqlParameter("@NewName", DbType.String),
                parameter2 = new SqlParameter("@TableName",DbType.String),
                parameter3 = new SqlParameter("@RoomID", DbType.Int32);
            parameter1.Value = NewName;
            parameter2.Value = TableName;
            parameter3.Value = RoomID;
            int count = DBContext.ExecuteBySql(sql,parameter1,parameter2,parameter3);
            if (count > 0) { return true; }
            return false;
        }
        public static bool deleteTable(string TableName,int RoomID)
        {
            string sql = "delete [Table] "
                + "where TableName = @TableName and RoomID = @RoomID ";
            SqlParameter parameter1 = new SqlParameter("@TableName", DbType.String),
                parameter2 = new SqlParameter("@RoomID",DbType.Int32);
            parameter1.Value = TableName;
            parameter2.Value = RoomID;
            int count = DBContext.ExecuteBySql(sql, parameter1,parameter2);
            if (count > 0) { return true; }
            return false;
        }

    }
}
