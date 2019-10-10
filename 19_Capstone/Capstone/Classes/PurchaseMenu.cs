using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class PurchaseMenu
    {
        public void purchaseMenu()
        {
            bool menu = true;
            while (menu == true)
            {

                Console.WriteLine($"\t\t\t\tPurchase Menu \n\t\t\t\t1) Feed Money \n\t\t\t\t2) Select Product \n\t\t\t\t3) Finish \n\t\t\t\t {Money.balance:c}");
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
                    Console.WriteLine($"\t\t\t\t1) $1 \n\t\t\t\t2) $2 \n\t\t\t\t3) $5 \n\t\t\t\t4) $10");
                    string inputm = Console.ReadLine().ToLower().Trim();
                    if (inputm == "1")
                    {
                        Money.AddMoney(1.00M);
                        Console.Clear();
                        continue;
                    }
                    if (inputm == "2")
                    {
                        Money.AddMoney(2.00M);
                        Console.Clear();
                        continue;
                    }
                    if (inputm == "3")
                    {
                        Money.AddMoney(5.00M);
                        Console.Clear();
                        continue;
                    }
                    if (inputm == "4")
                    {
                        Money.AddMoney(10.00M);
                        Console.Clear();
                        continue;
                    }
                }
                if (input == "2")
                {
                    Console.WriteLine("Please enter a valid product code: ");
                    string inputl = Console.ReadLine().Trim();
                    //if (Inventory.checkProductCode(inputl))
                    //{
                        if (Inventory.checkInventory(inputl))
                        {
                            Inventory.dispenseProduct(inputl);
                            Money.SubtractMoney(Products.ProductPrice);
                            Inventory.updateInventory(inputl);
                        }
                        else
                        {
                        Console.WriteLine("SOLD OUT");
                        }
                        continue;
                    //}
                    //Console.WriteLine("Invalid Product Code");
                    //continue;
                }
                if (input == "3")
                {
                    Money.GiveChange(Money.balance);
                    Console.ReadLine();
                    Console.Clear();
                    menu = false;
                    break;

                }
            }
        }

    }
}