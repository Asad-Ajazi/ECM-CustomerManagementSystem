using System;
using ECM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestVaild()
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

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Smith"
            };
            string expected = "Smith";

            //-- Act
            var fullName = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, fullName);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "John"
            };
            string expected = "John";

            //-- Act
            var fullName = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, fullName);
        }
    }
}
