using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Inventory
    {
        public static string location { get; private set; }

        public static bool checkInventory(string location)
        {
            if (amountInStock > 0)
            
            // TODO Checks if product is in-stock
            return true;
        }

        public static bool checkProductCode(string location)
        {
            // TODO Checks if product exists
            return true;
        }
        public static string dispenseProduct(string location)
        {
            // TODO  Display message for different product types

            if (productType == "Chip")
            {
                Console.Write("Crunch Crunch, Yum!");
            }

            if (productType == "Candy")
            {
                Console.Write("Munch Munch, Yum!");
            }

            if (productType == "Drink")
            {
                Console.Write("Glug Glug, Yum!");
            }


            if (productType == "Gum")
            {
                Console.Write("Chew Chew, Yum!");
            }

        }
        public static void updateInventory(string location)
        {
            // TODO Update amount remaining
            inventoryLevel[Location]--;
        }
    }
}
