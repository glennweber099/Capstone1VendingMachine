using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapstoneTests
{
    [TestClass]
    public class MoneyTests
    {
        private class Money { }

        [DataTestMethod]
        //[DataRow(, , DisplayName = "")]


        public void BalanceTest1()
        {
            // Arrange
            // Create a new object
            Money product = new Money();

            // Act
            decimal actualResult = 0.0M;

            // Assert
            //Assert.AreEqual(expectedResult, actualResult);
        }
    }
    
}
