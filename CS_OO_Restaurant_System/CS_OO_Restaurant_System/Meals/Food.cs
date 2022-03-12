using CS_OO_Restaurant_System.Meals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_System
{
    public class Food : Item
    {        
        //public double Price { get; set; }
        public Food(double price = 0d) : base(price)
        {
           //price = price;
        }
        public double CheeseSandwich;
        public double ChickenSalad;
        public double FishSandwich;
        public double Fries;
        public double Hamburger;
        public double ChickenSandwich;
        public double OnionRings;
        public double Salad;

        public double Price_CheeseSandwich = 3.3;
        public double Price_ChickenSalad = 3.35;
        public double Price_FishSandwich = 3.9;
        public double Price_Fries = 2.5;
        public double Price_Hamburger = 4.5;
        public double Price_ChickenSandwich = 2.9;
        public double Price_OnionRings = 3.5;
        public double Price_Salad = 6.5;
        
        public double itemscost1;
        public double itemscost2;
        public double itemsCostFood;

        public double GetAmountFood()
        {
            itemscost1 = CheeseSandwich + ChickenSalad + Fries;
            itemscost2 = ChickenSandwich + OnionRings + FishSandwich + Salad + Hamburger;
            itemsCostFood = itemscost1 + itemscost2;
            return itemsCostFood;
        }
    }
}
