﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class PurchaseMenu
    {
        static void Main(string[] args)
        {
            bool menu = true;

            while (menu == true)
            {

                Console.WriteLine($"\t\t\t\t1) Feed Money \n\t\t\t\t2) Select Product \n\t\t\t\t3) Finish \n\t\t\t\t {Money.balance}");
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
                    string inputMoney = Console.ReadLine().ToLower().Trim();
                    if (input == "1")
                    {
                        AddMoney(1);
                        continue;
                    }
                    if (input == "2")
                    {
                        AddMoney(2);
                        continue;
                    }
                    if (input == "3")
                    {
                        AddMoney(5);
                        continue;
                    }
                    if (input == "4")
                    {
                        AddMoney(10);
                        continue;
                    }
                }
                if (input == "2")
                {
                    if (Inventory.CheckProductCode(location))
                    {
                        if (Inventory.CheckInventory(location))
                        {
                            Inventory.dispenseProduct(location);
                            Inventory.updateInventory(location);
                        }
                        Console.WriteLine("SOLD OUT");
                        continue;
                    }
                    continue;

                }
                if (input == "3")
                {

                }
            }
        }
    }
}