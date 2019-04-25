using System;
using Extra.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extra.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpaces()
        {
            // Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
