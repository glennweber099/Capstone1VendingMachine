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
            if (Products.inventoryLevel[location] > 0)
            {
                return true;
            }
            return false;
        }
        public static bool checkProductCode(string location)
        {
            if (Products.inventoryLevel.ContainsKey(location))
            {
                return true;
            }
            return false;
        }
        public static void dispenseProduct(string location)
        {
            if (Products.ProductType == "Chip")
            {
                Console.Write("Crunch Crunch, Yum!");
                Console.ReadLine();
            }

            else if (Products.ProductType == "Candy")
            {
                Console.Write("Munch Munch, Yum!");
                Console.ReadLine();
            }

            else if (Products.ProductType == "Drink")
            {
                Console.Write("Glug Glug, Yum!");
                Console.ReadLine();
            }


            else if (Products.ProductType == "Gum")
            {
                Console.Write("Chew Chew, Yum!");
                Console.ReadLine();
            }

            try
            {  
                //Directory.SetCurrentDirectory(@"../../../..");
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
            Products.inventoryLevel[location] -= 1;
        }
    }
}
