using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShipmentCalculator());
            var order = new Order()
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheSHipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShipmentCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1),order.Shipment.ShippingDate);
        }
    }

    public class FakeShipmentCalculator : IShippingCalculator
    {
        public double CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
