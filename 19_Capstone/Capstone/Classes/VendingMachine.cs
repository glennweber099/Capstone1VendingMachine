using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{

    public class VendingMachine : Dictionaries
    {
        public decimal Balance { get; private set; }
        public decimal PreviousBalance { get; private set; }

        public void InitiateBalance()
        {
            PreviousBalance = 0.00M;
        }
        public void AddMoney(decimal amount)
        {

            Balance += amount;
            WriteOutDeposit();
            PreviousBalance += amount;
        }
        public void SubtractMoney(decimal amount)
        {
            Balance -= amount;
        }
        public void UpdatePreviousBalance(decimal amount)
        {
            PreviousBalance -= amount;
        }

        public string GiveChange(decimal remainingBalance)
        {
            int quarterCount = 0;
            int dimeCount = 0;
            int nickelCount = 0;
            Console.WriteLine($"\t\t\t\tYour change is: {remainingBalance:c}");
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
            Balance = 0.0M;
            WriteOutChange();
            string returnString = $"\n\t\t\t\tQuarter(s):{quarterCount}\n \t\t\t\tDime(s):{dimeCount} \n \t\t\t\tNickel(s):{nickelCount}";
            return returnString;
            
        }

        public bool checkStockLevel(string location)
        {
            if (productStockLevels[location] > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkProductCode(string location)
        {
            if (productStockLevels.ContainsKey(location))
            {
                return true;
            }
            return false;
        }
        public void dispenseProductMessage(string location)
        {
            if (location.Substring(0, 1).ToLower() == "a")
            {
                Console.Write("\t\t\t\tCrunch Crunch, Yum!");
                Console.ReadLine();
            }
            else if (location.Substring(0, 1).ToLower() == "b")
            {
                Console.Write("\t\t\t\tMunch Munch, Yum!");
                Console.ReadLine();
            }
            else if (location.Substring(0, 1).ToLower() == "c")
            {
                Console.Write("\t\t\t\tGlug Glug, Yum!");
                Console.ReadLine();
            }
            else if (location.Substring(0, 1).ToLower() == "d")
            {
                Console.Write("\t\t\t\tChew Chew, Yum!");
                Console.ReadLine();
            }

        }

        public void updateStockLevel(string location)
        {
            (productStockLevels[location]) -= 1;
            WriteOutItem(location);
        }

        public void WriteOutItem(string location)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now} {productName[location]} {location.ToUpper()} {PreviousBalance:c} {Balance:c}";
                    writer.WriteLine(outputData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR Writing out File: {ex.Message}.  Please call support for assistance");
            }
        }

        public void WriteOutDeposit()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now} FEED MONEY: {PreviousBalance:c} {Balance:c}";
                    writer.WriteLine(outputData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR Writing out File: {ex.Message}.  Please call support for assistance");
            }
        }

        public void WriteOutChange()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now} GIVE CHANGE: {PreviousBalance:c} {Balance:c}";
                    writer.WriteLine(outputData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR Writing out File: {ex.Message}.  Please call support for assistance");
            }
        }

        public void WriteOutSalesReport()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter($"{DateTime.Now.ToString().Replace(":", "-").Replace("/", "-")}.txt", false))
                {
                    decimal amountRemainingInventory = 0.0M;

                    foreach (KeyValuePair<string, string> entry in productName)
                    {
                        int numberToWrite = 0;
                        numberToWrite = (productStockLevels[entry.Key]);
                        string outputData = $"{entry.Value}|{numberToWrite}";
                        writer.WriteLine(outputData);

                        amountRemainingInventory += (numberToWrite * productPrice[entry.Key]);

                    }
                    decimal correctedSales = 132.5M - amountRemainingInventory;
                    writer.WriteLine($"\n\nTotal Sales:  {correctedSales:c}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR Writing out File: {ex.Message}.  Please call support for assistance");
            }
        }

    }


}
