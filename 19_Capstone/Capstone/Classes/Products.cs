using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class Products
    {
        private const char separator = '|';

        public static string Location { get;  }
        public static string ProductName { get; }
        public static double ProductPrice { get;  }
        public static string ProductType { get; }
        public static int amountInStock
        {
            get
            {
                return inventoryLevel[Location];
            }
        }


        public Products(string location, string productName, double productPrice, string productType)
        {
            location = Location;
            productName = ProductName;
            productPrice = ProductPrice;
            productType = ProductType;
        }

        public static Dictionary<string, int> inventoryLevel = new Dictionary<string, int>()
        {
            { "A1", 5 },
            { "A2", 5 },
            { "A3", 5 },
            { "A4", 5 },
            { "B1", 5 },
            { "B2", 5 },
            { "B3", 5 },
            { "B4", 5 },
            { "C1", 5 },
            { "C2", 5 },
            { "C3", 5 },
            { "C4", 5 },
            { "D1", 5 },
            { "D2", 5 },
            { "D3", 5 },
            { "D4", 5 },
        };

        public static void LoadInventory()
        {
            // TODO: Load products from the file (Inventory.txt), parse and display inventory
            try
            {
                Directory.SetCurrentDirectory(@"../../../..");
                using (StreamReader sr = new StreamReader("Inventory.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string inputLine = sr.ReadLine();
                        string[] fields = inputLine.Split(separator);

                        Products product = new Products(fields[0], fields[1], double.Parse(fields[2]), fields[3]);

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
