using System;
using ECM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestVaid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "John",
                LastName = "Smith"
            };
            string expected = "Smith, John";

            //-- Act
            var fullName = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, fullName);
        }
    }
}
