using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_System.Functionality
{
    public class CSV_Handler
    {
        public void WriteFoodDataToCSV(string coordinates, Food food) // <-- Metodas nenaudojamas
        {
            string path = $@"C:\Users\dvitk\OneDrive\Desktop\CS_OO_Restaurant_System\CS_OO_Restaurant_System\CSV_Directory\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{food.Name}, " +
                                                      $"{food.Price}";
            File.AppendAllText(path, DataString);

            //string appendText = "This is text for Column 1" + comma + "This is text for Column 2" + comma + "This is text for Column 3" + comma + Environment.NewLine;
        }
        public List<Food> ReadFoodCSVData(string CSVCoordinates)
        {
            string path = $@"C:\Users\dvitk\OneDrive\Desktop\CS_OO_Restaurant_System\CS_OO_Restaurant_System\CSV_Directory\{CSVCoordinates}.csv";
            // Open the file to read from.
            var CSVLineReader = new StreamReader(path);

            //var sweetsParcel = new Food();
            var foodRepository = new List<Food>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(',');

                foodRepository.Add(ItemParserFood(valueCache));
            }
            return foodRepository;
        }

        public Food ItemParserFood(string[] valueCache)
        {
            var foodParcel = new Food();
            //foodParcel.Name = double.Parse(valueCache[0].ToString());
            foodParcel.Price = double.Parse(valueCache[0].ToString());

            return foodParcel;
        }
        public void WriteDrinksDataToCSV(string coordinates, Drinks drinks) // <-- Metodas nenaudojamas
        {
            string path = $@"C:\Users\dvitk\OneDrive\Desktop\CS_OO_Restaurant_System\CS_OO_Restaurant_System\CSV_Directory\{coordinates}.csv";
            string DataString = Environment.NewLine + $"{drinks.Name}, " +
                                                      $"{drinks.Price}";
            File.AppendAllText(path, DataString);

            //string appendText = "This is text for Column 1" + comma + "This is text for Column 2" + comma + "This is text for Column 3" + comma + Environment.NewLine;
        }
        public List<Drinks> ReadDrinksCSVData(string CSVCoordinates)
        {
            string path = $@"C:\Users\dvitk\OneDrive\Desktop\CS_OO_Restaurant_System\CS_OO_Restaurant_System\CSV_Directory\{CSVCoordinates}.csv";
            // Open the file to read from.
            var CSVLineReader = new StreamReader(path);

            //var drinksParcel = new Drinks();
            var drinksRepository = new List<Drinks>();

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                string[] valueCache = line.Split(',');

                drinksRepository.Add(ItemParserDrinks(valueCache));
            }
            return drinksRepository;
        }
        public Drinks ItemParserDrinks(string[] valueCache)
        {
            var drinksParcel = new Drinks();
            drinksParcel.Price = double.Parse(valueCache[0].ToString());

            return drinksParcel;
        }
    }
}
