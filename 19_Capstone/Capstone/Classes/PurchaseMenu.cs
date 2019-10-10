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

                Console.WriteLine($"Purchase Menu \n\t\t\t\t1) Feed Money \n\t\t\t\t2) Select Product \n\t\t\t\t3) Finish \n\t\t\t\t {Money.balance}");
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

                    Console.WriteLine($"\t\t\t\t1) $1 \n\t\t\t\t2) $2 \n\t\t\t\t3) $5 \n\t\t\t\t4) $10");
                    if (input == "1")
                    {
                        Money.AddMoney(1);
                        continue;
                    }
                    if (input == "2")
                    {
                        Money.AddMoney(2);
                        continue;
                    }
                    if (input == "3")
                    {
                        Money.AddMoney(5);
                        continue;
                    }
                    if (input == "4")
                    {
                        Money.AddMoney(10);
                        continue;
                    }
                }
                if (input == "2")
                {
                    Console.WriteLine("Please enter a valid product code: ");
                    if (Inventory.checkProductCode(Inventory.location))
                    {
                        if (Inventory.checkInventory(Inventory.location))
                        {
                            Inventory.dispenseProduct(Inventory.location);
                            Money.SubtractMoney(Money.balance);
                            Inventory.updateInventory(Inventory.location);
                        }
                        Console.WriteLine("SOLD OUT");
                        continue;
                    }
                    Console.WriteLine("Invalid Product Code");
                    continue;
                }
                if (input == "3")
                {
                    Money.GiveChange(Money.balance);
                    menu = false;
                    break;

                }
            }
        }

    }
}