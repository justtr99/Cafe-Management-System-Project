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
                + "and (CAST(TimeCheckOut AS DATE) between @Start and @End) order by TimeCheckIn "
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
                    int.Parse(dr["AccountID"].ToString())
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
                + "WHERE (CAST(TimeCheckIn AS DATE) BETWEEN @start AND @end) "
                + "AND (CAST(TimeCheckOut AS DATE) BETWEEN @start AND @end) "
                + " ) AS bill;";
            SqlParameter parameter1 = new SqlParameter("@start", DbType.String),
                parameter2 = new SqlParameter("@end", DbType.String);
            parameter1.Value = Start;
            parameter2.Value = End;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1, parameter2);
            foreach (DataRow dr in dt.Rows) 
            {
                count = int.Parse(dr["dem"].ToString());
            }
            return count;
        }

        public static float doanhThuByDay(string Start, string End)
        {
            float doanhThu = 0;
            string sql = "SELECT sum(Total) as doanhThu FROM ( "
                + "SELECT Total \r\n    FROM Bill "
                + "WHERE (CAST(TimeCheckIn AS DATE) BETWEEN @start AND @end) "
                + "AND (CAST(TimeCheckOut AS DATE) BETWEEN @start AND @end) "
                + " ) AS bill;";
            SqlParameter parameter1 = new SqlParameter("@start", DbType.String),
                parameter2 = new SqlParameter("@end", DbType.String);
            parameter1.Value = Start;
            parameter2.Value = End;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1, parameter2);
            foreach (DataRow dr in dt.Rows)
            {
                doanhThu = float.Parse(dr["doanhThu"].ToString());
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
                    DateTime.Parse(dr["TimeCheckOut"].ToString()),
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

    }
}
