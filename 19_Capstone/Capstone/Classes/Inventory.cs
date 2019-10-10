using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Inventory
    {
        public static string location { get; }

        public bool checkInventory(string location)
        {
            // TODO Checks if product is in-stock
        }

        public bool checkProductCode(string location)
        {
            // TODO Checks if product exists
        }
        public void dispenseProduct(string location)
        {
            // TODO  Display message for different product types
        }
        public void updateInventory(string location)
        {
            // TODO Update amount remaining

        }
    }
}
