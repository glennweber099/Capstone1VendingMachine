using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;


namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void AddMoneyWorks()
        {
            VendingMachine acc = new VendingMachine();

            //Testing 2 Deposits
            acc.AddMoney(5.00M);
            Assert.AreEqual(5.00M, acc.balance);
            acc.AddMoney(15.00M);
            Assert.AreEqual(20.00M, acc.balance);

        }
        [TestMethod]
        public void SubtractMoneyWorks()
        {
            VendingMachine acc = new VendingMachine();

            //Initial Deposit
            acc.AddMoney(25.00M);

            // Testing 2 purchases lowering the balance
            acc.SubtractMoney(5.00M);
            Assert.AreEqual(20M, acc.balance);
            acc.SubtractMoney(3.00M);
            Assert.AreEqual(17M, acc.balance);

        }

        [TestMethod]
        public void CheckInventoryWorks()
        {
            VendingMachine acc = new VendingMachine();
            Assert.AreEqual(true, acc.checkInventory("A2"));
        }


        [DataTestMethod]
        [DataRow("A2", true, DisplayName = "Testing A2")]
        [DataRow("C4", true, DisplayName = "Testing C4")]
        [DataRow("E4", false, DisplayName = "Testing E4")]
        [DataRow("", false, DisplayName = "Testing empty string")]

        public void CheckProductCodeWorks1(string location, bool expectedResult)
        {
            VendingMachine acc = new VendingMachine();

            //Checking whether the product code is valid (True/False)
            bool actualResult = acc.checkProductCode(location);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [DataTestMethod]
        [DataRow(3.50, 0, 0, 0, DisplayName = "")]
        [DataRow(2.50, 0, 0, 0, DisplayName = "")]

        public string CheckGiveChange(double changeAmount, int expectedNickelCount)
        {
            VendingMachine acc = new VendingMachine();
            decimal conversion = 0.00M;
            conversion = (decimal)changeAmount;
            acc.GiveChange(conversion);

            Assert.AreEqual(CheckGiveChange(changeAmount), ($"\nQuarter(s):{acc.GiveChange((decimal)changeAmount).quarterCount}\n Dime(s):{dimeCount} \n Nickel(s):{nickelCount}"));
            Assert.AreEqual();


        }

        //[TestMethod]
        //public void Check()
        //{
        //    VendingMachine acc = new VendingMachine();

        //}

        [DataTestMethod]
        [DataRow("A2", 5, true, DisplayName = "Testing A2")]
        [DataRow("C4", 5, true, DisplayName = "Testing C4")]

        public void CheckInventoryTest(string location, int expectedStock, bool expectedResult)
        {
            VendingMachine acc = new VendingMachine();
            bool actualResult = acc.checkInventory(location);
            int actualStock = acc.stockedMachineInventory[location];

            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedStock, actualStock);

        }

    }

}