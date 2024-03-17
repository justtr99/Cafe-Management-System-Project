using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.Del
{
    internal class DBContext
    {
        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
            var strConnection = config["ConnectionString:MyStoreDB"];
            return strConnection;
        }
        public static SqlConnection GetConnection()
        {
            string ConnectionStr = GetConnectionString();
            return new SqlConnection(ConnectionStr);
        }



        public static DataTable GetDataBySql(String sql, params SqlParameter[] parameters) //doi tuong parms khi ko chuyen tham so vao thi no mac dinh la null
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());//su dung de thuc thi cac cau lenh
            if (parameters != null || parameters.Length == 0)
                command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter();//sử dụng để kết nối giữa DataSet và cơ sở dữ liệu SQL Server. Nó chịu trách nhiệm về quá trình truy xuất dữ liệu từ cơ sở dữ liệu và đổ dữ liệu vào DataSet,
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static int ExecuteBySql(String sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length == 0)
                command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            return count;

        }
    }
}
