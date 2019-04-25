using System;
using ECM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            // arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(3)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 24, 10, 0, 0, new TimeSpan(7, 0, 0))
            };

            // act
            var actual = orderRepository.Retrieve(3);


            // assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

        }
    }
}
