using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class PurchaseMenu : VendingMachine
    {
        public void PurchaseMenuUI()
        {
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine($"\t\t\t\tPurchase Menu \n\t\t\t\t1) Feed Money \n\t\t\t\t2) Select Product \n\t\t\t\t3) Finish \n\n\t\t\t\t Balance: {Balance:c}");
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

                    Console.Clear();
                    Console.WriteLine($"\t\t\t\tPurchasing Item... ");
                    Console.WriteLine($"\t\t\t\tBalance: {Balance:c}\n");
                    Products.LoadInventory();
                    
                    Console.WriteLine("\n\n\t\t\t\tPlease enter a valid product code: ");
                    string inputl = Console.ReadLine().Trim().ToUpper();
                    Console.Clear();
                    if ((Balance > 0))
                    {
                        if (checkProductCode(inputl.ToUpper()))
                        {
                            decimal actualPrice = productPrice[inputl];
                            string actualName = productName[inputl];
                            if ((Balance > actualPrice))
                            {
                                if (checkStockLevel(inputl))
                                {
                                    SubtractMoney(actualPrice);
                                    updateStockLevel(inputl);
                                    UpdatePreviousBalance(actualPrice);
                                    Console.Clear();
                                    dispenseProductMessage(inputl);
                                    Console.WriteLine($"\t\t\t\tThank you for purchasing {actualName}.\n\t\t\t\tPress [ENTER] to return to the menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("\t\t\t\tSOLD OUT");
                                }
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\t\t\t\tPlease put more money in and try again");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }
                        }
                        Console.WriteLine("\t\t\t\tInvalid Product Code");
                        Console.WriteLine("\t\t\t\tPress [ENTER] to return to Purchase menu");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\t\t\t\tPlease put more money in and try again. Press [ENTER] to continue");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                }
                if (input == "3")
                {
                    Console.Clear();
                    Console.WriteLine($"\t\t\t\t{GiveChange(Balance)}");
                    Console.WriteLine("\n\t\t\t\tPlease press [ENTER] to return to the menu");
                    Console.ReadLine();
                    Console.Clear();
                    menu = false;
                    break;

                }
            }
        }

    }
}