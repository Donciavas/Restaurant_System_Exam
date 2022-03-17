using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_OO_Restaurant_System.Meals;

namespace Restaurant_System
{
    public class Drinks : Food
    {
        public string Name { get; internal set; }

        public Drinks(string name = "", double price = 0d) //: base(price)
        {
            Name = name;
            Price = price;
        }
        public double WaterBottle;
        public double ChocolateMilkShake;
        public double Coffee;
        public double Cola;
        public double Orange;
        public double Tea;
        public double VanillaShake;
        public double BerryShake;
        public double StrawberryShake;

        public double Price_WaterBottle = 2.2;
        public double Price_ChocolateMilkShake = 4.2;
        public double Price_Coffee = 2.5;
        public double Price_Cola = 2.1;
        public double Price_Orange = 2.2;
        public double Price_Tea = 1.5;
        public double Price_VanillaShake = 3.5;
        public double Price_BerryShake = 3.5;
        public double Price_StrawberryShake = 3.5;

        public double itemsCost3;
        public double itemsCost4;
        public double itemsCostDrinks;


        public double GetAmountDrinks()
        {
            itemsCostDrinks = Convert.ToDouble($"{WaterBottle + ChocolateMilkShake + Coffee + Cola + Orange + Tea + VanillaShake + BerryShake + StrawberryShake}");
            
            return itemsCostDrinks;
        }
       

    }
}
