using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class MainMenu
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(@"../../../..");
            bool menum = true;
            while (menum == true)
            {

                Console.WriteLine($"\t\t\t\t\tMain Menu \n\t\t\t\t\t1) Display Items \n\t\t\t\t\t2) Purchase Menu \n\t\t\t\t\t3) Exit");
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
                    Console.Clear();
                    Products.LoadInventory();
                    Console.WriteLine("\t\t\tPlease press [ENTER] to return to the menu");
                    Console.ReadLine();
                    Console.Clear();
                    
                }
                if (input == "2")
                {
                    Console.Clear();
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
