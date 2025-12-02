
using testvetov2;

namespace TestVetov
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TotalPrice_IsCorrect()
        {
            var order = new Order { ProductName = "Laptop", Quantity = 3, PricePerUnit = 1000 };
            Assert.That(order.TotalPrice(), Is.EqualTo(3000));
        }

        [Test]

        public void CalculateTotalRevenuee_IsCorrect()
        {
            var controller = new OrderControler();
            controller.AddOrder(new Order { ProductName = "Laptop", Quantity = 2, PricePerUnit = 1000 });
            controller.AddOrder(new Order { ProductName = "Phone", Quantity = 5, PricePerUnit = 500 });
            Assert.That(controller.CalculateTotalRevenue(), Is.EqualTo(4500));
        }

        [Test]

        public void TotalPrice_ThrowsException_ForNegativeQuantity()
        {
           var order=new Order { ProductName = "Laptop", Quantity = -1, PricePerUnit = 1000 };
            Assert.Throws<ArgumentException>(() => order.TotalPrice());
        }

        [Test]

        public void TotalPrice_ThrowsExpectation_ForNegativePrice()
        {
            var controller = new OrderControler();
            controller.AddOrder(new Order { ProductName = "Laptop", Quantity = 2, PricePerUnit = -1000 });
            controller.AddOrder(new Order { ProductName = "Phone", Quantity = 5, PricePerUnit = -500 });
            Assert.Throws<ArgumentException>(() => controller.CalculateTotalRevenue());
        }

    }

}
