using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class MainMenu : VendingMachine
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(@"../../../..");
            //VendingMachine VM = new VendingMachine();
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

                    option.PurchaseMenuUI();
                }
                if (input == "3")
                {
                    menum = false;
                    break;
                }
                //if (input == "4")
                //{
                //    Console.Clear();
                //    //TODO  Print Correct Sales Report from VendingMachine.cs, stock values are resetting.

                //    VendingMachine ex = new VendingMachine();
                //    ex.WriteOutSalesReport();
                //    Console.WriteLine("\t\t\tSales Report Printed. Please press [ENTER] to return to the menu");
                //    Console.ReadLine();
                //    Console.Clear();

                //    continue;
                //}


            }
        }
    }
}
