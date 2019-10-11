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
            acc.AddMoney(5.00M);
            Assert.AreEqual(5.00M, acc.balance);
            
        }
        [TestMethod]
        public void SubtractMoneyWorks()
        {
            VendingMachine acc = new VendingMachine();
            acc.AddMoney(5.00M);
            acc.SubtractMoney(5.00M);
            Assert.AreEqual(0M, acc.balance);

        }
    }

}