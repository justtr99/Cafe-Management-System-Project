﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Models
{
    public class FoodDTO
    {
        public int FoodId { get; set; }    
        public string FoodName { get; set; }
        public int Quantity { get; set; }
        public float FoodPrice { get; set; }
        public string TypeName { get; set; }
        public int FoodCategoryID { get; set; }

        public string imgLink { get; set; }


        public FoodDTO() { }

        public FoodDTO(int foodId, string foodName, float foodPrice, int foodCategoryID, int quantity)
        {
            FoodId = foodId;
            FoodName = foodName;
            FoodPrice = foodPrice;
            FoodCategoryID = foodCategoryID;
            Quantity = quantity;
            if(foodCategoryID == 1)
            {
                TypeName = "Đồ ăn";
            }
            else
            {
                TypeName = "Đồ uống";
            }
        }

        public FoodDTO(int foodId, string foodName, float foodPrice, int foodCategoryID, int quantity, string imgLink)
        {
            FoodId = foodId;
            FoodName = foodName;
            FoodPrice = foodPrice;
            FoodCategoryID = foodCategoryID;
            Quantity = quantity;
            if (foodCategoryID == 1)
            {
                TypeName = "Đồ ăn";
            }
            else
            {
                TypeName = "Đồ uống";
            }
            this.imgLink = imgLink;
        }

        public FoodDTO(string foodName, int quantity, float foodPrice)
        {
            FoodName = foodName;
            Quantity = quantity;
            FoodPrice = foodPrice;
        }
    }
}
