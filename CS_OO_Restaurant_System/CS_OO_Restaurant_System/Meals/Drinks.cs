using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_System
{
    class Drinks: Food
    {
        public double WaterBottle;
        public double ChocolateMilkShake;
        public double Coffee;
        public double Cola;
        public double Orange;
        public double Tea;
        public double VanillaShake;
        public double BerryShake;
        public double Strawberry;

        public double Price_BottleWater = 2.2;
        public double Price_ChocolateMilkShake = 4.2;
        public double Price_Coffee = 2.5;
        public double Price_Cola = 2.0;
        public double Price_Orange = 2.2;
        public double Price_Tea = 1.5;
        public double Price_VanillaShake = 3.5;
        public double Price_BerryShake = 3.5;
        public double Price_Strawberry = 3.5;

        public double itemsCost3;
        public double itemsCost4;
        public double itemsCostDrinks;


        public double GetAmountDrinks()
        {
            itemsCost3 = WaterBottle + Tea + ChocolateMilkShake + VanillaShake;
            itemsCost4 = Coffee + Cola + Orange + BerryShake + Strawberry;
            itemsCostDrinks = itemsCost3 + itemsCost4;
            return itemsCostDrinks;
        }
       

    }
}
