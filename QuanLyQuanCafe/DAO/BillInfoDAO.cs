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
    public class BillInfoDAO
    {
        public static List<BillInfoDTO> getAllBillInfoByID(int ID)
        {
            List<BillInfoDTO> listBillInfo = new List<BillInfoDTO>();
            string sql = "select * from BillInfo where BillID = @ID ";
            SqlParameter parameter1 = new SqlParameter("@ID",DbType.Int32);
            parameter1.Value = ID;
            DataTable dt = DBContext.GetDataBySql(sql,parameter1);
            foreach (DataRow dr in dt.Rows)
            {
                listBillInfo.Add(new BillInfoDTO(
                    int.Parse(dr["BillInfoID"].ToString()),
                    int.Parse(dr["BillID"].ToString()),
                    int.Parse(dr["FoodID"].ToString()),
                    int.Parse(dr["Quantity"].ToString())
                    ));
            }

            return listBillInfo;
        } 
        public static BillInfoDTO GetBillInfoByTableAndFood(int BillID,int FoodID)
        {
            BillInfoDTO billInfoDTO = new BillInfoDTO();
            string sql = "select * from BillInfo "
                + "where BillID = @BillInfoID and FoodID = @FoodID";
            SqlParameter parameter1 = new SqlParameter("@BillInfoID", DbType.Int32),
                parameter2 = new SqlParameter("@FoodID", DbType.Int32);
            parameter1.Value = BillID;
            parameter2.Value = FoodID;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1,parameter2);
            foreach (DataRow dr in dt.Rows)
            {
                billInfoDTO = new BillInfoDTO(
                    int.Parse(dr["BillInfoID"].ToString()),
                    int.Parse(dr["BillID"].ToString()),
                    int.Parse(dr["FoodID"].ToString()),
                    int.Parse(dr["Quantity"].ToString())
                    );
            }
            return billInfoDTO;

        }

        public static bool updateBillInfo(int Quantity, int BillID, int FoodID)
        {
            string sql = "update BillInfo "
                + "set Quantity = @Quantity "
                + "where BillID = @BillID and FoodID = @FoodID ";
            SqlParameter parameter1 = new SqlParameter("@Quantity", DbType.Int32),
                parameter2 = new SqlParameter("@BillID", DbType.Int32),
                parameter3 = new SqlParameter("@FoodID", DbType.Int32);
            parameter1.Value = Quantity;
            parameter2.Value = BillID;
            parameter3.Value = FoodID;
            int count = DBContext.ExecuteBySql(sql, parameter1,parameter2,parameter3); 
            if(count > 0) { return true; }
            return false;
        }

        public static bool deleteBiffInfo(int BillID, int FoodID)
        {
            string sql = "delete BillInfo "
                + "where BillID = @BillID and FoodID = @FoodID ";
            SqlParameter parameter1 = new SqlParameter("@BillID", DbType.Int32),
                parameter2 = new SqlParameter("@FoodID", DbType.Int32);
            parameter1.Value = BillID;
            parameter2.Value = FoodID;
            int count = DBContext.ExecuteBySql(sql, parameter1, parameter2);
            if(count > 0) { return true; }
            return false;
        }

        public static bool insertBillInfo(int BillID,int FoodID, int Quantity)
        {
            string sql = "insert into BillInfo "
                + "values (@BillID,@FoodID,@Quantity)";
            SqlParameter parameter1 = new SqlParameter("@BillID", DbType.Int32),
                parameter2 = new SqlParameter("@FoodID", DbType.Int32),
                parameter3 = new SqlParameter("@Quantity",DbType.Int32);
            parameter1.Value = BillID;  
            parameter2.Value = FoodID;
            parameter3.Value = Quantity;
            int count = DBContext.ExecuteBySql(sql, parameter1, parameter2, parameter3);
            if(count > 0) { return true; }

            return false;
        }
        
        

        }
    }

