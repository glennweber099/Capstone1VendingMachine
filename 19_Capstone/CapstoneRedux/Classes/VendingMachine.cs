using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CapstoneRedux.Classes
{
    public class VendingMachine
    {
        public double Balance { get; private set; }
        public double PreviousBalance { get; private set; }

        public List<Product> LoadInventory()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (StreamReader sr = new StreamReader("Inventory.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string inputLine = sr.ReadLine();
                        string[] fields = inputLine.Split("|");
                        Product product = new Product(fields[0], fields[1], Convert.ToDouble(fields[2]), fields[3]);
                        products.Add(product);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an ERROR loading the file {"Inventory.txt"}.  The error was {ex.Message}");
            }
            return products;
        }

        public void DisplayInventory(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.ToString()}");
            }

        }

        public void AddMoney(double amount)
        {

            Balance += amount;
            WriteOutDeposit();
            PreviousBalance += amount;
        }
        public void SubtractMoney(double amount)
        {
            Balance -= amount;
        }
        public void UpdatePreviousBalance(double amount)
        {
            PreviousBalance -= amount;
        }

        public string GiveChange(double remainingBalance)
        {
            int quarterCount = 0;
            int dimeCount = 0;
            int nickelCount = 0;
            Console.WriteLine($"\t\t\t\tYour change is: {remainingBalance:c}");
            while (remainingBalance >= 0.25)
            {
                remainingBalance -= 0.25;
                quarterCount++;
            }
            while (remainingBalance >= 0.10)
            {
                remainingBalance -= 0.10;
                dimeCount++;
            }
            while (remainingBalance >= 0.05)
            {
                remainingBalance -= 0.05;
                nickelCount++;
            }
            Balance = 0.0;
            WriteOutChange();
            string returnString = $"\n\t\t\t\tQuarter(s):{quarterCount}\n \t\t\t\tDime(s):{dimeCount} \n \t\t\t\tNickel(s):{nickelCount}";
            return returnString;

        }

        public bool checkStockLevel(Product product)
        {
            if (product.Quantity > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkProductCode(Product product, string location)
        {
            if (product.Location.ToString().Contains(location))
            {
                return true;
            }
            return false;
        }
        public void dispenseProductMessage(Product product)
        {
            if (product.Type.ToString() == "Chip")
            {
                Console.Write("\t\t\t\tCrunch Crunch, Yum!");
                Console.ReadLine();
            }
            else if (product.Type.ToString() == "Candy")
            {
                Console.Write("\t\t\t\tMunch Munch, Yum!");
                Console.ReadLine();
            }
            else if (product.Type.ToString() == "Drink")
            {
                Console.Write("\t\t\t\tGlug Glug, Yum!");
                Console.ReadLine();
            }
            else if (product.Type.ToString() == "Gum")
            {
                Console.Write("\t\t\t\tChew Chew, Yum!");
                Console.ReadLine();
            }

        }

        public void updateStockLevel(Product product)
        {
            product.Quantity--;
        }

        public void WriteOutItem(Product product)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Log.txt", true))
                {
                    string outputData = $"{DateTime.Now} {product.Name} {product.Location.ToUpper()} {PreviousBalance:c} {Balance:c}";
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

    }
}
