using System.Collections.Generic;
using Restaurant_System;
using Restaurant_System.Functionality;

namespace CS_OO_Restaurant_System.Repositories
{
    public class FoodRepository
    {
        public List<Food> FoodList { get; set; }

        public FoodRepository()
        {
            FoodList = new List<Food>();
        }
        public List<Food> LoadFoodCSVData()
        {
            var handler = new CSV_Handler();
            FoodList = handler.ReadFoodCSVData("Food");
            return FoodList;
        }
        public void AddFoodToCSV(Food food)
        {
            var handler = new CSV_Handler();
            handler.WriteFoodDataToCSV("Food", food);
        }
    }
}