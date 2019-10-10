using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{

    public class Money
    {
        public static decimal balance { get; private set; }
        public static decimal previousBalance { get; private set; }

        public static void InitiateBalance()
        {
            previousBalance = 0.00M;
        }
        public static void AddMoney(decimal amount)
        {

            balance += amount;
            Transaction.writeOutDeposit(amount);
            previousBalance += amount;
        }
        public static void SubtractMoney(decimal amount)
        {
            balance -= amount;
        }
        public static void UpdatePreviousBalance(decimal amount)
        {
            previousBalance -= amount;
        }

        public static string GiveChange(decimal remainingBalance)
        {
            int quarterCount = 0;
            int dimeCount = 0;
            int nickelCount = 0;
            while (remainingBalance >= 0.25M)
            {
                remainingBalance -= 0.25M;
                quarterCount++;
            }
            while (remainingBalance >= 0.10M)
            {
                remainingBalance -= 0.10M;
                dimeCount++;
            }
            while (remainingBalance >= 0.05M)
            {
                remainingBalance -= 0.05M;
                nickelCount++;
            }
            string returnString = $"\nQuarter(s):{quarterCount}\n Dime(s):{dimeCount} \n Nickel(s):{nickelCount}";
            return returnString;
        }
    }
}
