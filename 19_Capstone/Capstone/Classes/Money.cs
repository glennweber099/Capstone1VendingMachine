using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{

    public class Money
    {
        public static decimal balance { get; private set; }
        public static void AddMoney(int amount)
        {
            balance += amount;
        }
    }
}
