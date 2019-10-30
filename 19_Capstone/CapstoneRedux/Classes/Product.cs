using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneRedux.Classes
{
    public class Product
    {
        public string Location { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }


        public Product()
        {

        }

        public Product (string location, string name, double price, string type)
        {
            Location = location;
            Name = name;
            Price = price;
            Type = type;
            Quantity = 5;
        }

        public override string ToString()
        {
            string returnText = $"\t\t{Location} | {Name, 20} | {Price:c} | Quantity Remaining: {Quantity}";
            return returnText;
        }
    }
}
