using QuanLyCafe.Del;
using QuanLyQuanCafe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class QRDAO
    {
        public static QRDTO getQR()
        {
            QRDTO qr = new QRDTO();
            string sql = "select * from QR";
            DataTable dt = DBContext.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                qr = new QRDTO(int.Parse(dr["QRId"].ToString()), dr["nganHang"].ToString(), dr["Stk"].ToString(), dr["Template"].ToString(), dr["TenTk"].ToString(), dr["ThongTinThem"].ToString());
            }

            return qr;
        }
        public static bool updateQR(string nganhang, string Stk, string Template, string TenTk, string ThongTinThem)
        {
            string sql = "update QR "
                + "set nganHang = @nganhang , Stk = @Stk , Template = @Template , TenTk = @TenTk , ThongTinThem = @ThongTinThem  "
                + "where QRId = 1";
            SqlParameter parameter1 = new SqlParameter("@nganhang", DbType.String),
                parameter2 = new SqlParameter("@Stk", DbType.String),
                parameter3 = new SqlParameter("@Template", DbType.String),
                parameter4 = new SqlParameter("@TenTk", DbType.String),
                parameter5 = new SqlParameter("@ThongTinThem", DbType.String);
            parameter1.Value = nganhang;
            parameter2.Value = Stk;
            parameter3.Value = Template;
            parameter4.Value = TenTk;
            parameter5.Value = ThongTinThem;
            int count = DBContext.ExecuteBySql(sql, parameter1,parameter2,parameter3,parameter4,parameter5);
            if(count > 0)
            {
                return true;
            }
            return false;

        }
    }
}
