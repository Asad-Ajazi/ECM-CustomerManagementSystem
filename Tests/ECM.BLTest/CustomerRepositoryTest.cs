using System;
using System.Collections.Generic;
using ECM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "JSmith@gmail.com",
                FirstName = "John",
                LastName = "Smith"
            };
            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "JSmith@gmail.com",
                FirstName = "John",
                LastName = "Smith",
                AddresseList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Street1",
                        StreetLine2 = "Street2",
                        City = "London",
                        State = "Shire",
                        Country = "United Kindom",
                        PostalCode = "SE1 7PB"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "First Street",
                        StreetLine2 = "Second Street",
                        City = "Brighton",
                        State = "Shire",
                        Country = "United Kindom",
                        PostalCode = "BN1"
                    }
                }
            };
            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddresseList[i].AddressType, actual.AddresseList[i].AddressType);
                Assert.AreEqual(expected.AddresseList[i].StreetLine1, actual.AddresseList[i].StreetLine1);
                Assert.AreEqual(expected.AddresseList[i].City, actual.AddresseList[i].City);
                Assert.AreEqual(expected.AddresseList[i].State, actual.AddresseList[i].State);
                Assert.AreEqual(expected.AddresseList[i].Country, actual.AddresseList[i].Country);
                Assert.AreEqual(expected.AddresseList[i].PostalCode, actual.AddresseList[i].PostalCode);
            }
        }

    }
}
