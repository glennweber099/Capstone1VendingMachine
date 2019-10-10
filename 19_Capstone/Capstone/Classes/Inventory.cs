using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class Inventory
    {

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
            if (Products.ProductType == "Chip")
            {
                Console.Write("Crunch Crunch, Yum!");
            }

            else if (Products.ProductType == "Candy")
            {
                Console.Write("Munch Munch, Yum!");
            }

            else if (Products.ProductType == "Drink")
            {
                Console.Write("Glug Glug, Yum!");
            }


            else if (Products.ProductType == "Gum")
            {
                Console.Write("Chew Chew, Yum!");
            }

            try
            {   // TODO Update variables to call data
                Directory.SetCurrentDirectory(@"../../../..");
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now}{Products.ProductName} {Products.Location} {Products.ProductPrice} {Money.balance}";
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
            Products.inventoryLevel[location] -= 1;
        }
    }
}
