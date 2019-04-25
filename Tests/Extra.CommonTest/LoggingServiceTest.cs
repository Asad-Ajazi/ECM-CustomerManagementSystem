using System;
using System.Collections.Generic;
using ECM.BL;
using Extra.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extra.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "JSmith@gmail.com",
                FirstName = "John",
                LastName = "Smith",
                AddresseList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Spade",
                ProductDescription = "A metal spade",
                CurrentPrice = 4M
            };
            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
            // nothing to assert as not actually writing to a file.


        }
    }
}
