using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.Del;
using QuanLyCafe.Models;
using System.Web;

namespace QuanLyCafe.DAO
{
    public class AccountDAO
    {
        public static AccountDTO getAccount(String Username,String Password)
        {
            AccountDTO accountDTO = null;
            string sql = "select * from Account where Username = @Username and Password = @Password ";
            SqlParameter parameters1 = new SqlParameter("@Username", DbType.String),
                parameters2 = new SqlParameter("@Password",DbType.String);
            parameters1.Value = Username;
            parameters2.Value = Password;
            DataTable dt = DBContext.GetDataBySql(sql, parameters1, parameters2);
            List<AccountDTO> list = new List<AccountDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                accountDTO = new AccountDTO(Convert.ToInt32(dr["AccountID"].ToString()), dr["FullName"].ToString(), dr["Phone"].ToString(), dr["Username"].ToString(), dr["Password"].ToString(), Convert.ToInt32(dr["RoleID"].ToString()));
            }
            return accountDTO;
        }
        public static List<AccountDTO> getAllAccount()
        {
            List<AccountDTO> list =new List<AccountDTO> ();
            string sql = "select * from Account";
            DataTable dt = DBContext.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new AccountDTO(int.Parse(dr["AccountID"].ToString()), dr["FullName"].ToString(), dr["Phone"].ToString(), dr["Username"].ToString(), dr["Password"].ToString()));
            }
            return list;
        }

        public static bool insertAccount(String Username, String Password,String Name,String Phone)
        {
            AccountDTO accountDTO = null;
            string sql = "insert into Account values(@name,@phone,@username,@password,1)";
            SqlParameter parameters1 = new SqlParameter("@name", DbType.String),
                parameters2 = new SqlParameter("@phone", DbType.String),
                parameters3 = new SqlParameter("@username", DbType.String),
                parameters4 = new SqlParameter("@password", DbType.String);
            parameters1.Value = Name;
            parameters2.Value = Phone;
            parameters3.Value = Username;
            parameters4.Value = Password;
            int count = DBContext.ExecuteBySql(sql, parameters1, parameters2, parameters3, parameters4);
            if (count > 0)
                return true;
            return false;
        }
        public static bool updateAccount(String UsenameNow,String Username, String Password, String Name, String Phone)
        {

            string sql = "update Account "
                + "set FullName = @name, Phone = @phone, Username = @username, Password = @password "
                + "where Username = @UsernameNow";
            SqlParameter parameters1 = new SqlParameter("@name", DbType.String),
                parameters2 = new SqlParameter("@phone", DbType.String),
                parameters3 = new SqlParameter("@username", DbType.String),
                parameters4 = new SqlParameter("@password", DbType.String),
                parameters5 = new SqlParameter("@UsernameNow", DbType.String);
            parameters1.Value = Name;
            parameters2.Value = Phone;
            parameters3.Value = Username;
            parameters4.Value = Password;
            parameters5.Value = UsenameNow;
            int count = DBContext.ExecuteBySql(sql, parameters1, parameters2, parameters3, parameters4, parameters5);
            if (count > 0) return true;
            return false;
        }
        public static bool deleteAccount(String username)
        {
            string sql = "delete Account\r\nwhere Username = @username";
            SqlParameter parameters1 = new SqlParameter("@username", DbType.String);
            parameters1.Value = username;
            int count = DBContext.ExecuteBySql(sql, parameters1);
            if (count > 0) return true;
            return false;
        }

        public static List<AccountDTO> getAccountByFullName(String FullName)
        {
            List<AccountDTO> list = new List<AccountDTO>();
            string sql = "select * from Account where FullName like @FullName";
            SqlParameter parameters1 = new SqlParameter("@FullName", DbType.String);
            parameters1.Value = "%"+ FullName + "%";
            DataTable dt = DBContext.GetDataBySql(sql,parameters1);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new AccountDTO(int.Parse(dr["AccountID"].ToString()), dr["FullName"].ToString(), dr["Phone"].ToString(), dr["Username"].ToString(), dr["Password"].ToString()));
            }
            return list;
        }

        public static bool updatePass(int id, string oldPass, string newPass)
        {
            string sql = "update Account "
                + "set [Password] = @newPass "
                + "where AccountID = @id and [Password] = @oldPass";
            SqlParameter parameters1 = new SqlParameter("id", DbType.Int32),
                parameter2 = new SqlParameter("@oldPass", DbType.String),
                parameter3 = new SqlParameter("@newPass",DbType.String);
            parameters1.Value = id; 
            parameter2.Value = oldPass;
            parameter3.Value = newPass;
            int cout = DBContext.ExecuteBySql(sql,parameters1,parameter2,parameter3);
            if( cout > 0 )
            {
                return true;
            }

            return false;
        }
    }
}
