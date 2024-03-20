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
    public class BillDAO
    {
        public static List<BillDTO> getAllBillByDay(string Start, string End,int page)
        {
            List<BillDTO> listBill = new List<BillDTO>();
            string sql = "SELECT * FROM Bill WHERE (CAST(TimeCheckIn AS DATE) between @Start and @End) "
                + " order by TimeCheckIn "
                + "Offset @page rows fetch next 15 rows only";
            SqlParameter parameter1 = new SqlParameter("@Start", DbType.String),
                parameter2 = new SqlParameter("@End", DbType.String),
                parameter3 = new SqlParameter("@page", DbType.Int32);
            parameter1.Value = Start;
            parameter2.Value = End;
            parameter3.Value = (page - 1) * 15;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1, parameter2,parameter3);
            foreach (DataRow dr in dt.Rows)
            {
                if(dr["BillStatus"].ToString().Equals("Đã thanh toán"))
                {
                    listBill.Add(new BillDTO(
                    int.Parse(dr["BillID"].ToString()),
                    DateTime.Parse(dr["TimeCheckIn"].ToString()),
                    DateTime.Parse(dr["TimeCheckOut"].ToString()),
                    int.Parse(dr["TableID"].ToString()),
                    dr["BillStatus"].ToString(),
                    int.Parse(dr["AccountID"].ToString()),
                    float.Parse(dr["Total"].ToString())
                    ));
                }
                
            }
            return listBill;    
        }

        public static List<BillDTO> getAllBillByDayEachEmployee(string Start, string End, int page,int empID)
        {
            List<BillDTO> listBill = new List<BillDTO>();
            string sql = "SELECT * FROM Bill WHERE (CAST(TimeCheckIn AS DATE) between @Start and @End) and Bill.AccountID = @id "
                + " order by TimeCheckIn "
                + "Offset @page rows fetch next 10 rows only";
            SqlParameter parameter1 = new SqlParameter("@Start", DbType.String),
                parameter2 = new SqlParameter("@End", DbType.String),
                parameter3 = new SqlParameter("@page", DbType.Int32),
                parameter4 = new SqlParameter("@id", DbType.Int32);

            parameter1.Value = Start;
            parameter2.Value = End;
            parameter3.Value = (page - 1) * 10;
            parameter4.Value = empID;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1, parameter2, parameter3,parameter4);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["BillStatus"].ToString().Equals("Đã thanh toán"))
                {
                    listBill.Add(new BillDTO(
                    int.Parse(dr["BillID"].ToString()),
                    DateTime.Parse(dr["TimeCheckIn"].ToString()),
                    DateTime.Parse(dr["TimeCheckOut"].ToString()),
                    int.Parse(dr["TableID"].ToString()),
                    dr["BillStatus"].ToString(),
                    int.Parse(dr["AccountID"].ToString()),
                    float.Parse(dr["Total"].ToString())
                    ));
                }

            }
            return listBill;
        }

        public static int countBillByDay(string Start, string End)
        {
            int count = 0;
            string sql = "SELECT COUNT(BillID) as dem FROM ( "
                + "SELECT BillID \r\n    FROM Bill "
                + "WHERE (CAST(TimeCheckIn AS DATE) BETWEEN @start AND @end)  "
                + " "
                + " ) AS bill;";
            SqlParameter parameter1 = new SqlParameter("@start", DbType.String),
                parameter2 = new SqlParameter("@end", DbType.String);
            parameter1.Value = Start;
            parameter2.Value = End;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1, parameter2);
            foreach (DataRow dr in dt.Rows) 
            {
                if (dr["dem"] != null)
                {
                    count = int.Parse(dr["dem"].ToString());
                }
                else count = 0;
            }
            return count;
        }

        public static int countBillByDayEmployee(string Start, string End,int empID)
        {
            int count = 0;
            string sql = "SELECT COUNT(BillID) as dem FROM ( "
                + "SELECT BillID \r\n    FROM Bill "
                + "WHERE (CAST(TimeCheckIn AS DATE) BETWEEN @start AND @end) and Bill.AccountID = @id "
                + " ) AS bill;";
            SqlParameter parameter1 = new SqlParameter("@start", DbType.String),
                parameter2 = new SqlParameter("@end", DbType.String),
                parameter3 = new SqlParameter("@id",DbType.Int32);
            
            parameter1.Value = Start;
            parameter2.Value = End;
            parameter3.Value = empID;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1, parameter2, parameter3);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["dem"] != null)
                {
                    count = int.Parse(dr["dem"].ToString());
                }
                else count = 0;
            }
            return count;
        }

        public static float doanhThuByDay(string Start, string End)
        {
            float doanhThu = 0;
            string sql = "SELECT sum(Total) as doanhThu FROM ( "
                + "SELECT Total \r\n    FROM Bill "
                + "WHERE (CAST(TimeCheckIn AS DATE) BETWEEN @start AND @end) "
                + " "
                + " ) AS bill;";
            SqlParameter parameter1 = new SqlParameter("@start", DbType.String),
                parameter2 = new SqlParameter("@end", DbType.String);
            parameter1.Value = Start;
            parameter2.Value = End;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1,parameter2);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["doanhThu"] != null && dr["doanhThu"].ToString().Length>0)
                {
                    doanhThu = float.Parse(dr["doanhThu"].ToString());
                }else doanhThu = 0;
            }
            return doanhThu;
        }
        public static BillDTO checkBillByTable(int TableID)
        {
            BillDTO billDTO = null;
            string sql = "select * from Bill "
                + "where TableID = @TableID and BillStatus = N'Chưa thanh toán'";
            SqlParameter parameter1 = new SqlParameter("@TableID", DbType.Int32);
            parameter1.Value = TableID;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1);
            foreach (DataRow dr in dt.Rows)
            {
                billDTO = new BillDTO(
                    int.Parse(dr["BillID"].ToString()),
                    DateTime.Parse(dr["TimeCheckIn"].ToString()),
                    int.Parse(dr["TableID"].ToString()),
                    dr["BillStatus"].ToString(),
                    int.Parse(dr["AccountID"].ToString())
                    );
            }
            return billDTO;

        }
        public static bool deleteBill(int id)
        {
            string sql = "delete Bill "
                + "where BillID = @id";
            SqlParameter parameter1 = new SqlParameter("@id", DbType.Int32);
            parameter1.Value = id;
            int count = DBContext.ExecuteBySql(sql, parameter1);
            if (count > 0)
            {
                return true;
            }

            return false;
        }
        public static bool insertBill(int TableID,int AccountID)
        {
            string sql = "insert into Bill (TimeCheckIn,TableID,BillStatus,AccountID) "
                + "values (GETDATE(),@TableID,N'Chưa thanh toán',@AccountID) ";
            SqlParameter parameter1 = new SqlParameter("@TableID", DbType.Int32),
                parameter2 = new SqlParameter("@AccountID",DbType.Int32);
            parameter1.Value = TableID;
            parameter2.Value = AccountID;
            int count = DBContext.ExecuteBySql(sql, parameter1, parameter2);
            if (count > 0) { return true; }

            return false;
        }

        public static int getBillByTable(int tableID)
        {
            int id = 0;
            string sql = "select BillID "
                + "from Bill "
                + " Where TableID = @ID and BillStatus = N'Chưa thanh toán'";
            SqlParameter parameter1 = new SqlParameter("@ID",DbType.Int32);
            parameter1.Value = tableID;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1);
            foreach (DataRow dr in dt.Rows) {
               id = int.Parse(dr["BillID"].ToString());
            }
            return id;

        }

        public static bool thanhToan(int BillID)
        {
            string sql = "update Bill "
                + "set BillStatus = N'Đã thanh toán', TimeCheckOut = GETDATE() \n"
                + "where BillID = @id";
            SqlParameter parameter1 = new SqlParameter("@id",DbType.Int32);
            parameter1.Value = BillID;
            int count = DBContext.ExecuteBySql(sql, parameter1);
            if (count > 0) { return true; }
            return false;
        }

        public static bool tinhTotal(int BillID)
        {
            string sql = "update Bill "
                + "set Total = (select total from ( "
                + "select Sum (Food.FoodPrice * BillInfo.Quantity) as total,BillInfo.BillID "
                + "from BillInfo "
                + "join Food on BillInfo.FoodID = Food.FoodID "
                + "where BillInfo.BillID = @id "
                + "group by BillInfo.BillID ) tinhTien ) "
                + "where BillID = @id  ";
            SqlParameter parameter1 = new SqlParameter("@id", DbType.Int32);
            parameter1.Value = BillID;
            int count = DBContext.ExecuteBySql(sql, parameter1);
            if (count > 0) { return true; }
            return false;
        }
        public static bool changeTable(int oldTable, int newTable)
        {
            string sql = "update Bill "
                + "set TableID = @new "
                + "where TableID = @old and BillStatus = N'Chưa thanh toán' ";
            SqlParameter parameter1 = new SqlParameter("@new", DbType.Int32),
                parameter2 = new SqlParameter("@old", DbType.Int32);
            parameter1.Value = newTable;
            parameter2.Value = oldTable;
            int count = DBContext.ExecuteBySql(sql, parameter1, parameter2);
            if (count > 0) { return true; }

            return false;
        }

    }
}
