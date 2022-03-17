using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_OO_Restaurant_System.Repositories;

namespace CS_OO_Restaurant_System.Functionality
{
    public class OrderAndChequeSystem
    {
        public class CartAndChequeSystem
        {
            #region CLASS GLOBALS
            public static List<string> cartList = new List<string>();
            public static string Cheque;
            public static double cartTotal = 0d;
            //public static decimal wallet = 0m;
            public static List<double> moneyOperations = new List<double>();
            #endregion

            #region ADD TO CART
            static public void AddFoodToCartList(int index)
            {
                var foodRepository = new FoodRepository();
                //var itemIdentifier = new ItemAuthenticator();

                for (int i = 0; i < foodRepository.LoadFoodCSVData().Count; i++)
                {
                    if (i == index)
                    {
                        cartList.Add($"{(foodRepository.LoadFoodCSVData()[index])} už {foodRepository.LoadFoodCSVData()[index].Price} Eur");
                    }
                }
                cartTotal += foodRepository.LoadFoodCSVData()[index].Price;
                moneyOperations.Add(foodRepository.LoadFoodCSVData()[index].Price);
            }
            static public void AddDrinksToCartList(int index)
            {
                var drinksRepository = new DrinksRepository();
                //var itemIdentifier = new ItemAuthenticator();

                for (int i = 0; i < drinksRepository.LoadDrinksCSVData().Count; i++)
                {
                    if (i == index)
                    {
                        cartList.Add($"{(drinksRepository.LoadDrinksCSVData()[index])} už {drinksRepository.LoadDrinksCSVData()[index].Price} Eur");
                    }
                }
                cartTotal += drinksRepository.LoadDrinksCSVData()[index].Price;
                moneyOperations.Add(drinksRepository.LoadDrinksCSVData()[index].Price);
            }
            #endregion
        }
    }
}

