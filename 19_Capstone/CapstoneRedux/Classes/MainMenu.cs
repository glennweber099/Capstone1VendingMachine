using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneRedux.Classes
{
    public class MainMenu
    {
        static void Main(string[] args)
        {
            bool menum = true;
            VendingMachine VM = new VendingMachine();
            List<Product> products = VM.LoadInventory();
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
                    VM.DisplayInventory(products);
                    Console.WriteLine("\n\t\t\tPlease press [ENTER] to return to the menu");
                    Console.ReadLine();
                    Console.Clear();

                }
                if (input == "2")
                {
                    bool menup = true;
                    while (menup == true)
                    {
                        Console.Clear();
                        {
                            Console.WriteLine($"\t\t\t\tPurchase Menu \n\t\t\t\t1) Feed Money \n\t\t\t\t2) Select Product \n\t\t\t\t3) Finish \n\n\t\t\t\t Balance: {VM.Balance:c}");
                            string inputTwo = Console.ReadLine().ToLower().Trim();
                            if (inputTwo.Length == 0)
                            {
                                Console.Clear();
                                continue;

                            }
                            if (inputTwo.Length > 1)
                            {
                                Console.Clear();
                                continue;

                            }
                            if (inputTwo == "1")
                            {
                                Console.Clear();
                                Console.WriteLine($"\t\t\t\t1) $1 \n\t\t\t\t2) $2 \n\t\t\t\t3) $5 \n\t\t\t\t4) $10");
                                string inputm = Console.ReadLine().ToLower().Trim();
                                if (inputm == "1")
                                {
                                    VM.AddMoney(1.00);
                                    Console.Clear();
                                    continue;
                                }
                                if (inputm == "2")
                                {
                                    VM.AddMoney(2.00);
                                    Console.Clear();
                                    continue;
                                }
                                if (inputm == "3")
                                {
                                    VM.AddMoney(5.00);
                                    Console.Clear();
                                    continue;
                                }
                                if (inputm == "4")
                                {
                                    VM.AddMoney(10.00);
                                    Console.Clear();
                                    continue;
                                }
                                menup = true;
                            }
                            if (inputTwo == "2")
                            {

                                Console.Clear();
                                Console.WriteLine($"\t\t\t\tPurchasing Item... ");
                                Console.WriteLine($"\t\t\t\tBalance: {VM.Balance:c}\n");
                                VM.DisplayInventory(products);

                                Console.WriteLine("\n\n\t\t\t\tPlease enter a valid product code: ");
                                string inputl = Console.ReadLine().Trim().ToUpper();
                                Product activeProduct = new Product();
                                foreach (Product product in products)
                                {
                                    if (product.Location.ToString() == inputl)
                                    {
                                        activeProduct = product;
                                    }
                                }
                                Console.Clear();
                                if ((VM.Balance > 0))
                                {
                                    double actualPrice = activeProduct.Price;
                                    string actualName = activeProduct.Name;
                                    if ((VM.Balance > actualPrice))
                                    {
                                        if (VM.checkStockLevel(activeProduct))
                                        {
                                            VM.SubtractMoney(actualPrice);
                                            VM.updateStockLevel(activeProduct);
                                            VM.UpdatePreviousBalance(actualPrice);
                                            VM.WriteOutItem(activeProduct);
                                            Console.Clear();
                                            VM.dispenseProductMessage(activeProduct);
                                            Console.WriteLine($"\t\t\t\tThank you for purchasing {activeProduct.Name}.\n\t\t\t\tPress [ENTER] to return to the menu");
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
                                else
                                {
                                    Console.WriteLine("\t\t\t\tPlease put more money in and try again. Press [ENTER] to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    continue;
                                }

                            }
                            if (inputTwo == "3")
                            {
                                Console.Clear();
                                Console.WriteLine($"\t\t\t\t{VM.GiveChange(VM.Balance)}");
                                Console.WriteLine("\n\t\t\t\tPlease press [ENTER] to return to the menu");
                                Console.ReadLine();
                                Console.Clear();
                                menup = false;
                                break;

                            }
                        }

                    }
                    if (input == "3")
                    {

                        menum = false;
                        Environment.Exit(0);
                    }
                    if (input == "4")
                    {
                        Console.Clear();

                        //VendingMachine ex = new VendingMachine();
                        //ex.WriteOutSalesReport();
                        //Console.WriteLine("\t\t\tSales Report Printed. Please press [ENTER] to return to the menu");
                        //Console.ReadLine();
                        //Console.Clear();

                    }


                }

            }
        }
    }
}
