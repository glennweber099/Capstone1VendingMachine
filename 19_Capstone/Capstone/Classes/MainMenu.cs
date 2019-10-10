using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class MainMenu
    {
        static void Main(string[] args)
        {
            bool menum = true;
            while (menum == true)
            {

                Console.WriteLine($"Main Menu \n\t\t\t\t1) Display Items \n\t\t\t\t2) Purchase \n\t\t\t\t3) Exit");
                string input = Console.ReadLine().ToLower().Trim();
                if (input.Length == 0)
                {
                    Console.Clear();
                    continue;

                }
                if (input.Length > 1)
                {
                    Console.Clear();
                    continue;

                }
                if (input == "1")
                {
                    Products.LoadInventory();
                }
                if (input == "2")
                {
                    PurchaseMenu option = new PurchaseMenu();

                    option.purchaseMenu();
                }
                if (input == "3")
                {
                    menum = false;
                    break;
                }
                
            }
        }
    }
}
