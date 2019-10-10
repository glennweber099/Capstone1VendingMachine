using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class Products
    {
        private const char separator = '|';

        public static string Location { get; private set; }
        public static string ProductName { get; private set; }
        public static decimal ProductPrice { get; private set; }
        public static string ProductType { get; private set; }

        public static Dictionary<string, int> inventoryLevel = new Dictionary<string, int>(){};

        public Products(string location, string productName, decimal productPrice, string productType)
        {
            Location = location;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductType = productType;
            
        }


        public static void LoadInventory()
        {
            List<Products> products = new List<Products>();
            try
            {
                //Directory.SetCurrentDirectory(@"../../../..");
                using (StreamReader sr = new StreamReader("Inventory.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string inputLine = sr.ReadLine();
                        string[] fields = inputLine.Split(separator);
                        Products product = new Products(fields[0], fields[1], decimal.Parse(fields[2]), fields[3]);
                        Console.WriteLine($"{fields[0]} - {fields[1]} - ${fields[2]:C}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Inform the user 
                Console.WriteLine($"There was an ERROR loading the file {"Inventory.txt"}.  The error was {ex.Message}");
            }
        }
    }
}
