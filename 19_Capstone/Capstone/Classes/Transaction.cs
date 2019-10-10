using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class Transaction
    {
        public static void writeOut()
        {
            try
            {
                //Directory.SetCurrentDirectory(@"../../../..");
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now}{Products.ProductName} {Products.Location} {Products.ProductPrice} {Money.balance}";
                    writer.WriteLine(outputData);

                }
            }
            catch (Exception ex)
            {
                // Report to the user that there was an error
                Console.WriteLine($"ERROR saving task list: {ex.Message}.  Please call support at 867-5309");
            }
        }
    }
}
