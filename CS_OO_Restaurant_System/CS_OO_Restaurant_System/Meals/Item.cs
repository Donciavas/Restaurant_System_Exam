using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OO_Restaurant_System.Meals
{
    public class Item
    {
        // - Tėvinė klasė prekė (kaina)
        public double Price { get; set; }

        public Item(double price = 0d)
        {
            Price = price;
        }
    }
}