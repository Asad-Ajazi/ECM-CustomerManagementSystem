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

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var customer1 = new Customer();
            Customer.InstanceCount++;

            var customer2 = new Customer();
            Customer.InstanceCount++;

            var customer3 = new Customer();
            Customer.InstanceCount++;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateVaild()
        {
            //-- Arrange
            Customer customer1 = new Customer
            {
                LastName = "Smith",
                EmailAddress = "JSmith@gmail.com"
            };
            var expected = true;

            //-- Act
            var actual = customer1.Validate();

            //-- Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            Customer customer1 = new Customer
            {                
                EmailAddress = "JSmith@gmail.com"
            };
            var expected = false;

            //-- Act
            var actual = customer1.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
