using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class Transaction
    {
        public static void writeOutItem(string location)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now} {VendingMachine.productName[location]} {location.ToUpper()} {Money.previousBalance:c} {Money.balance:c}";
                    writer.WriteLine(outputData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR saving task list: {ex.Message}.  Please call support at 867-5309");
            }
        }

        public static void writeOutDeposit(decimal amount)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now} FEED MONEY: {Money.previousBalance:c} {Money.balance:c}";
                    writer.WriteLine(outputData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR saving task list: {ex.Message}.  Please call support at 867-5309");
            }
        }
    }
}
