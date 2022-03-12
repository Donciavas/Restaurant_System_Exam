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
            foodParcel.Price = double.Parse(valueCache[1].ToString());

            return foodParcel;
        }
    }
}
