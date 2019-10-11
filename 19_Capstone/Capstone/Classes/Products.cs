using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class Products : VendingMachine
    {
        private const char separator = '|';

        public static void LoadInventory()
        {
            try
            {
                using (StreamReader sr = new StreamReader("Inventory.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string inputLine = sr.ReadLine();
                        string[] fields = inputLine.Split(separator);
                        Console.WriteLine($"\t\t\t\t{fields[0]} - {fields[1]} - ${fields[2]:C}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an ERROR loading the file {"Inventory.txt"}.  The error was {ex.Message}");
            }
        }
    }
}
