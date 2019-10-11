using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class Dictionaries 
    {
        public Dictionary<string, int> productStockLevels = new Dictionary<string, int>()
        {
            {"A1", 5 },
            {"A2", 5 },
            {"A3", 5 },
            {"A4", 5 },
            {"B1", 5 },
            {"B2", 5 },
            {"B3", 5 },
            {"B4", 5 },
            {"C1", 5 },
            {"C2", 5 },
            {"C3", 5 },
            {"C4", 5 },
            {"D1", 5 },
            {"D2", 5 },
            {"D3", 5 },
            {"D4", 5 },
        };


        public Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>()
        {
            {"A1", 3.05M},
            {"A2", 1.45M },
            {"A3", 2.75M },
            {"A4", 3.65M },
            {"B1", 1.80M },
            {"B2", 1.50M },
            {"B3", 1.50M },
            {"B4", 1.75M },
            {"C1", 1.25M },
            {"C2", 1.50M },
            {"C3", 1.50M },
            {"C4", 1.50M },
            {"D1", 0.85M },
            {"D2", 0.95M },
            {"D3", 0.75M },
            {"D4", 0.75M },
        };

        public Dictionary<string, string> productName = new Dictionary<string, string>()
        {
            {"A1", "Potato Crisps"},
            {"A2", "Stackers"},
            {"A3", "Grain Waves"},
            {"A4", "Cloud Popcorn"},
            {"B1", "Moonpie"},
            {"B2", "Cowtales"},
            {"B3", "Wonka Bar"},
            {"B4", "Crunchie"},
            {"C1", "Cola"},
            {"C2", "Dr. Salt"},
            {"C3", "Mountain Melter"},
            {"C4", "Heavy"},
            {"D1", "U-Chews"},
            {"D2", "Little League Chew"},
            {"D3", "Chiclets"},
            {"D4", "Triplemint"},
        };

    }
}
