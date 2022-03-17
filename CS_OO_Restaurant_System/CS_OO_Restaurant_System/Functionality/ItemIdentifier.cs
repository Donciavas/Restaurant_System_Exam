using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OO_Restaurant_System.Functionality
{
    public class ItemAuthenticator
    {
         public string ItemIdentifier(string name)
         {
             string returningName = "";
             switch (name)
             {
                 case "CheeseSandwich":
                     returningName = "CheeseSandwich";
                     break;
                 /*case string name = {ChickenSalad}:
                     returningName = "Hamburger";
                     break;
                 case string FishSandwich:
                     returningName = "Hamburger";
                     break;
                 case string Fries:
                     returningName = "Hamburger";
                     break;
                 case string Hamburger:
                     returningName = "Hamburger";
                     break;
                 case string ChickenSandwich:
                     returningName = "Hamburger";
                     break;
                 case string OnionRings:
                     returningName = "Hamburger";
                     break;
                 case string Salad:
                     returningName = "Hamburger";
                     break;*/


             }
             return returningName;
         }
    }
}
