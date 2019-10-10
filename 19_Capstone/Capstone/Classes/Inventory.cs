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
            //if (amountInStock > 0)
            
            // TODO Checks if product is in-stock
            return true;
        }

        public static bool checkProductCode(string location)
        {
            // TODO Checks if product exists
            return true;
        }
        public static void dispenseProduct(string location)
        {
            // TODO  Display message for different product types
            if (productType == "Chip")
            {
                Console.Write("Crunch Crunch, Yum!");
            }

            else if (productType == "Candy")
            {
                Console.Write("Munch Munch, Yum!");
            }

            else if (productType == "Drink")
            {
                Console.Write("Glug Glug, Yum!");
            }


            else if (productType == "Gum")
            {
                Console.Write("Chew Chew, Yum!");
            }

            try
            {   // TODO Update variables to call data
                using (StreamWriter writer = new StreamWriter(Log.txt, true))
                {
                    string outputData = $"{DateTime} {Products.ProductName} {Products.Location} {Products.ProductPrice} {Balance}";
                    writer.WriteLine(outputData);
                    
                }
            }
            catch (Exception ex)
            {
                // Report to the user that there was an error
                Console.WriteLine($"ERROR saving task list: {ex.Message}.  Please call support at 867-5309");
            }


        }
        public static void updateInventory(string location)
        {
            // TODO Update amount remaining
            inventoryLevel[Location] -= 1;
        }
    }
}
