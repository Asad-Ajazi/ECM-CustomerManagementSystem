using System;
using ECM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Roses",
                ProductDescription = "A set of 6 Roses.",
                CurrentPrice = 15.15M
            };

            // act 
            var actual = productRepository.Retrieve(2);

            // assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Roses",
                ProductDescription = "A set of 6 Roses.",
                CurrentPrice = 16.15M,
                HasChanges = true
            };

            // act 
            var actual = productRepository.Save(updatedProduct);

            // assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Roses",
                ProductDescription = "A set of 6 Roses.",
                CurrentPrice = null,
                HasChanges = true
            };

            // act 
            var actual = productRepository.Save(updatedProduct);

            // assert
            Assert.AreEqual(false, actual);
        }

    }


}
