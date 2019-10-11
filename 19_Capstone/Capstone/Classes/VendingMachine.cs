using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{

    public class VendingMachine
    {
        public decimal balance { get; set; }
        public decimal previousBalance { get; set; }

        public void InitiateBalance()
        {
            previousBalance = 0.00M;
        }
        public void AddMoney(decimal amount)
        {

            balance += amount;
            writeOutDeposit();
            previousBalance += amount;
        }
        public void SubtractMoney(decimal amount)
        {
            balance -= amount;
        }
        public void UpdatePreviousBalance(decimal amount)
        {
            previousBalance -= amount;
        }

        public string GiveChange(decimal remainingBalance)
        {
            int quarterCount = 0;
            int dimeCount = 0;
            int nickelCount = 0;
            Console.WriteLine($"Your change is: {remainingBalance:c}");
            while (remainingBalance >= 0.25M)
            {
                remainingBalance -= 0.25M;
                quarterCount++;
            }
            while (remainingBalance >= 0.10M)
            {
                remainingBalance -= 0.10M;
                dimeCount++;
            }
            while (remainingBalance >= 0.05M)
            {
                remainingBalance -= 0.05M;
                nickelCount++;
            }
            balance = 0.0M;
            writeOutChange();
            string returnString = $"\nQuarter(s):{quarterCount}\n Dime(s):{dimeCount} \n Nickel(s):{nickelCount}";
            return returnString;
            
        }

        public Dictionary<string, int> stockedMachineInventory = new Dictionary<string, int>()
        {
            {"A1", 5 },
            {"A2", 5 },
            {"A3", 5 },
            {"A4", 5 },
            {"B1", 5 },
            {"B2", 5 },
            {"B3", 5 },
            {"B4", 5 },
            {"C1", 5 },
            {"C2", 5 },
            {"C3", 5 },
            {"C4", 5 },
            {"D1", 5 },
            {"D2", 5 },
            {"D3", 5 },
            {"D4", 5 },
        };
        public Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>()
        {
            {"A1", 3.05M},
            {"A2", 1.45M },
            {"A3", 2.75M },
            {"A4", 3.65M },
            {"B1", 1.80M },
            {"B2", 1.50M },
            {"B3", 1.50M },
            {"B4", 1.75M },
            {"C1", 1.25M },
            {"C2", 1.50M },
            {"C3", 1.50M },
            {"C4", 1.50M },
            {"D1", 0.85M },
            {"D2", 0.95M },
            {"D3", 0.75M },
            {"D4", 0.75M },
        };

        public Dictionary<string, string> productName = new Dictionary<string, string>()
                    {
            {"A1", "Potato Crisps(chips)"},
            {"A2", "Stackers"},
            {"A3", "Grain Waves"},
            {"A4", "Cloud Popcorn"},
            {"B1", "Moonpie"},
            {"B2", "Cowtales"},
            {"B3", "Wonka Bar"},
            {"B4", "Crunchie"},
            {"C1", "Cola"},
            {"C2", "Dr. Salt"},
            {"C3", "Mountain Melter"},
            {"C4", "Heavy"},
            {"D1", "U-Chews"},
            {"D2", "Little League Chew"},
            {"D3", "Chiclets"},
            {"D4", "Triplemint"},
        };


        public void writeOutItem(string location)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now} {productName[location]} {location.ToUpper()} {previousBalance:c} {balance:c}";
                    writer.WriteLine(outputData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR saving task list: {ex.Message}.  Please call support at 867-5309");
            }
        }

        public void writeOutDeposit()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now} FEED MONEY: {previousBalance:c} {balance:c}";
                    writer.WriteLine(outputData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR saving task list: {ex.Message}.  Please call support at 867-5309");
            }
        }

        public void writeOutChange()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now} GIVE CHANGE: {previousBalance:c} {balance:c}";
                    writer.WriteLine(outputData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR saving task list: {ex.Message}.  Please call support at 867-5309");
            }
        }

        public  void writeOutSalesReport()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter($"{DateTime.Now.ToString().Replace(":","-").Replace("/","-")}.txt", false))
                {
                    decimal totalSales = 0.0M;

                    foreach (KeyValuePair<string, string> entry in productName)
                    {
                        int numberToWrite = 0;
                        numberToWrite = stockedMachineInventory[entry.Key];
                        string outputData = $"{entry.Value}|{numberToWrite}";
                        writer.WriteLine(outputData);

                        totalSales += (numberToWrite * productPrice[entry.Key]);

                    }

                    writer.WriteLine($"Total Sales:  {totalSales:c}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR saving task list: {ex.Message}.  Please call support at 867-5309");
            }
        }


        public bool checkInventory(string location)
        {
            if (stockedMachineInventory[location] > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkProductCode(string location)
        {
            if (stockedMachineInventory.ContainsKey(location))
            {
                return true;
            }
            return false;
        }
        public void dispenseProduct(string location)
        {
            if (location.Substring(0, 1).ToLower() == "a")
            {
                Console.Write("Crunch Crunch, Yum!");
                Console.ReadLine();
            }
            else if (location.Substring(0, 1).ToLower() == "b")
            {
                Console.Write("Munch Munch, Yum!");
                Console.ReadLine();
            }
            else if (location.Substring(0, 1).ToLower() == "c")
            {
                Console.Write("Glug Glug, Yum!");
                Console.ReadLine();
            }
            else if (location.Substring(0, 1).ToLower() == "d")
            {
                Console.Write("Chew Chew, Yum!");
                Console.ReadLine();
            }

        }
        public void updateInventory(string location)
        {
            stockedMachineInventory[location] -= 1;
            writeOutItem(location);
        }



    }
}
