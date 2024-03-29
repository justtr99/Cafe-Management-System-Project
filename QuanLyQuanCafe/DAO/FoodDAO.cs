﻿using QuanLyCafe.Del;
using QuanLyQuanCafe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class FoodDAO
    {
         public static List<FoodDTO> getAllFood()
        { 
            List<FoodDTO> list = new List<FoodDTO>();
            string sql = "select * from Food";
            DataTable dt = DBContext.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new FoodDTO(int.Parse(dr["FoodID"].ToString()), dr["FoodName"].ToString(), float.Parse(dr["FoodPrice"].ToString()), int.Parse(dr["FoodCategoryID"].ToString()), int.Parse(dr["Quantity"].ToString()), dr["ImageLink"].ToString()));
            }
            return list;

        }

        public static List<FoodDTO> getAllFoodByNameAndType(string name,string typeFood )
        {
            
            List<FoodDTO> list = new List<FoodDTO>();
            string sql = "select Food.* from Food "
                + "join FoodCategory on Food.FoodCategoryID = FoodCategory.FoodCategoryID "
                + "where FoodName like @name and FoodCategory.FoodCategoryName like @typeFood";
            SqlParameter parameters1 = new SqlParameter("@name", DbType.String),
               parameter2 = new SqlParameter("@typeFood", DbType.String);
            parameters1.Value = "%" + name + "%";
            parameter2.Value = "%" + typeFood + "%";
            DataTable dt = DBContext.GetDataBySql(sql,parameters1,parameter2);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new FoodDTO(int.Parse(dr["FoodID"].ToString()), dr["FoodName"].ToString(), float.Parse(dr["FoodPrice"].ToString()), int.Parse(dr["FoodCategoryID"].ToString()), int.Parse(dr["Quantity"].ToString()), dr["ImageLink"].ToString()));
            }
            return list;

        }

        public static List<FoodDTO> getSearchFood(string name,int type)
        {
            List<FoodDTO> list = new List<FoodDTO>();
            string sql;
            sql = "if(@type = 0) "
                + "select * from Food where FoodName like @name "
                + "else select * from Food where FoodName like @name and FoodCategoryID = @type";
            SqlParameter parameters1 = new SqlParameter("@name", DbType.String),
                parameter2 = new SqlParameter("@type", DbType.Int32);
            parameters1.Value = "%"+ name + "%";
            parameter2.Value = type;
            DataTable dt = DBContext.GetDataBySql(sql,parameters1,parameter2);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new FoodDTO(int.Parse(dr["FoodID"].ToString()), dr["FoodName"].ToString(), float.Parse(dr["FoodPrice"].ToString()), int.Parse(dr["FoodCategoryID"].ToString()), int.Parse(dr["Quantity"].ToString())));
            }
            return list;

        }
        public static bool insertFood(string name,float price,int FoodType,int Quantity,string linkImg)
        {
            string sql = "insert into Food values (@Name,@Price,@FoodType,@Quantity,@img)";
            SqlParameter parameter1 = new SqlParameter("@Name", DbType.String),
                parameter2 = new SqlParameter("@Price", SqlDbType.Float),
                parameter3 = new SqlParameter("@FoodType", DbType.Int32),
                parameter4 = new SqlParameter("@Quantity", DbType.Int32),
                parameter5 = new SqlParameter("@img", DbType.String);
            parameter1.Value = name;
            parameter2.Value = price;
            parameter3.Value = FoodType;
            parameter4.Value = Quantity; 
            parameter5.Value = linkImg;
            int count = DBContext.ExecuteBySql(sql,parameter1,parameter2,parameter3,parameter4,parameter5);
            if(count>0)
                return true;
            return false;
        }
        public static bool updateFood(int id,string name,float price,int type,int AddQuantity,string img)
        {
            string sql = "update Food "+
                "set FoodName = @FoodName, FoodPrice = @FoodPrice, FoodCategoryID = @FoodType, Quantity += @AddQuantity, ImageLink = @img "
                + "where FoodID = @FoodID";
            SqlParameter parameter1 = new SqlParameter("@FoodName", DbType.String),
                parameter2 = new SqlParameter("@FoodPrice", SqlDbType.Float),
                parameter3 = new SqlParameter("@FoodType", DbType.Int32),
                parameter4 = new SqlParameter("@AddQuantity", DbType.Int32),
                parameter5 = new SqlParameter("@FoodID", DbType.Int32),
                parameter6 = new SqlParameter("@img", DbType.String);
            parameter1.Value = name;
            parameter2.Value = price;
            parameter3.Value = type;
            parameter4.Value = AddQuantity;
            parameter5.Value = id;
            parameter6.Value = img;
            int count = DBContext.ExecuteBySql(sql, parameter1, parameter2, parameter3, parameter4,parameter5, parameter6);
            if(count>0) return true;
            return false;
        }
        public static bool deleteFood(int id)
        {
            string sql = "delete Food "
                + "where FoodID = @FoodID";
            SqlParameter parameter1 = new SqlParameter("@FoodID", DbType.Int32);
            parameter1.Value = id;
            int count = DBContext.ExecuteBySql(sql, parameter1);
            if(count>0) return true;
            return false;
        }

        public static FoodDTO getFoodByID(int id)
        {
            FoodDTO food = new FoodDTO();
            string sql = "select * from Food where FoodID = @ID";
            SqlParameter parameter1 = new SqlParameter("@ID",DbType.Int32);
            parameter1.Value = id;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1);
            foreach(DataRow dr in dt.Rows)
            {
                food = new FoodDTO(int.Parse(dr["FoodID"].ToString()), dr["FoodName"].ToString(), float.Parse(dr["FoodPrice"].ToString()),
                    int.Parse(dr["FoodCategoryID"].ToString()), int.Parse(dr["Quantity"].ToString())
                    );   
            }
            return food;
        }
        public static int getFoodIDByName(string name)
        {
            int id = 0;
            string sql = "select FoodID "
                + "from Food where FoodName =@name ";
            SqlParameter parameter1 = new SqlParameter("@name", DbType.String);
            parameter1.Value = name;
            DataTable dt = DBContext.GetDataBySql(sql, parameter1);
            foreach (DataRow dr in dt.Rows)
            {
                id = int.Parse(dr["FoodID"].ToString());
            }
            return id;
        }

    }
}
