using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{

    public class Money
    {
        public static decimal balance { get; private set; }
        public static void AddMoney(decimal amount)
        {
            balance = balance + amount;
        }
        public static void SubtractMoney(decimal amount)
        {
            balance -= amount;
        }
        public static string GiveChange(decimal remainingBalance)
        {
            string changeGivenString = ""; 
            int quarterCount = 0;
            int dimeCount = 0;
            int nickelCount = 0;
            while ((remainingBalance - 0.25M) > 0.10M)
            {
                remainingBalance -= 0.25M;
                quarterCount++;
            }
            while ((remainingBalance - 0.10M) > 0.05M)
            {
                remainingBalance -= 0.10M;
                dimeCount++;
            }
            while ((remainingBalance - 0.05M) >= 0M)
            {
                remainingBalance -= 0.05M;
                nickelCount++;
            }
            changeGivenString = $"Quarter(s): {quarterCount}\n Dime(s): {dimeCount} \n Nickel(s): {nickelCount}";
            return changeGivenString;

        }
    }
}
