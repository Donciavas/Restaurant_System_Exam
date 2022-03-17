using System.Collections.Generic;
using Restaurant_System;
using Restaurant_System.Functionality;

namespace CS_OO_Restaurant_System.Repositories
{
    public class DrinksRepository
    {
        public List<Drinks> DrinksList { get; set; }

        public DrinksRepository()
        {
            DrinksList = new List<Drinks>();
        }

        public List<Drinks> LoadDrinksCSVData()
        {
            var handler = new CSV_Handler();
            DrinksList = handler.ReadDrinksCSVData("Drinks");
            return DrinksList;
        }
        public void AddDrinksToCSV(Drinks drinks)
{
    var handler = new CSV_Handler();
    handler.WriteDrinksDataToCSV("Drinks", drinks);
}
    }
}