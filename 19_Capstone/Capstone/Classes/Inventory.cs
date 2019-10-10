using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class Inventory
    {
        public static bool checkInventory(string location)
        {
            if (VendingMachine.stockedMachineInventory[location] > 0)
            {
                return true;
            }
            return false;
        }
        public static bool checkProductCode(string location)
        {
            if (VendingMachine.stockedMachineInventory.ContainsKey(location))
            {
                return true;
            }
            return false;
        }
        public static void dispenseProduct(string location)
        {
            if (location.Substring(0,1).ToLower() == "a")
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
        public static void updateInventory(string location)
        {
            VendingMachine.stockedMachineInventory[location] -= 1;
            Transaction.writeOutItem(location);
        }
    }
}
