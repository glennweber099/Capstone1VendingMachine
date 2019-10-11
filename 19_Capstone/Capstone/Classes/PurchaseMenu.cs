using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class PurchaseMenu : VendingMachine
    {
        public void purchaseMenu()
        {
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine($"\t\t\t\tPurchase Menu \n\t\t\t\t1) Feed Money \n\t\t\t\t2) Select Product \n\t\t\t\t3) Finish \n\t\t\t\t {balance:c}");
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
                        AddMoney(1.00M);
                        Console.Clear();
                        continue;
                    }
                    if (inputm == "2")
                    {
                        AddMoney(2.00M);
                        Console.Clear();
                        continue;
                    }
                    if (inputm == "3")
                    {
                        AddMoney(5.00M);
                        Console.Clear();
                        continue;
                    }
                    if (inputm == "4")
                    {
                        AddMoney(10.00M);
                        Console.Clear();
                        continue;
                    }
                }
                if (input == "2")
                {
                    Products.LoadInventory();

                    Console.WriteLine("\t\t\t\tPlease enter a valid product code: ");
                    string inputl = Console.ReadLine().Trim().ToUpper();
                    Console.Clear();
                    if ((balance > 0))
                    {
                        if (checkProductCode(inputl.ToUpper()))
                        {
                            decimal actualPrice = productPrice[inputl];
                            string actualName = productName[inputl];
                            if ((balance > actualPrice))
                            {
                                if (checkInventory(inputl))
                                {
                                    SubtractMoney(actualPrice);
                                    updateInventory(inputl);
                                    UpdatePreviousBalance(actualPrice);
                                    Console.Clear();
                                    dispenseProduct(inputl);
                                    Console.WriteLine($"Thank you for purchasing {actualName}.\nPress [ENTER] to return to the menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("SOLD OUT");
                                }
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Please put more money in and try again");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }
                        }
                        Console.WriteLine("Invalid Product Code");
                        Console.WriteLine("Press [ENTER] to return to Purchase menu");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Please put more money in and try again. Press [ENTER] to continue");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                }
                if (input == "3")
                {
                    Console.WriteLine($"{GiveChange(balance)}");
                    Console.WriteLine("Please press [ENTER] to return to the menu");
                    Console.ReadLine();
                    Console.Clear();
                    menu = false;
                    break;

                }
            }
        }

    }
}