using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Products
    {
        public string Location { get;  }
        public string ProductName { get; }
        public double ProductPrice { get;  }
        public string ProductType { get; }

        public Product(string location, string productName, double productPrice, string productType)
        {
            location = Location;
            productName = ProductName;
        }

    }
}
