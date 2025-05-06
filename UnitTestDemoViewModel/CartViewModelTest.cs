using DemoUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestDemoViewModel
{
    [TestClass]
    public class CartViewModelTest
    {
        [TestMethod]
        public void TestTotalPrice()
        {
            // Arrange
            var expectedTotal = 1.875;
            double currentTotal = 0;
            var disscountMockService = new Mock<IDiscountService>();
            disscountMockService.Setup(m => m.Discount("verdura")).Returns(0.1);
            disscountMockService.Setup(m => m.Discount("frutta")).Returns(0.2);
            //disscountMockService.Setup(m => m.Login("testuser", "password")).Returns(true);
            var currentTimeMockService = new Mock<ICurrentTime>();
            CartViewModel viewModel = new CartViewModel(disscountMockService.Object, currentTimeMockService.Object, DateTime.Now);
            Product product1 = new Product() { Id = "1", Name = "Carote", Category = "verdura", Price = 0.28 };
            Product product2 = new Product() { Id = "2", Name = "Broccoli", Category = "verdura", Price = 0.47 };
            Product product3 = new Product() { Id = "3", Name = "Ananas", Category = "frutta", Price = 1.5 };
            // Act
            viewModel.AddProductToCartCommand.Execute(product1);
            viewModel.AddProductToCartCommand.Execute(product2);
            viewModel.AddProductToCartCommand.Execute(product3);
            // Assert
            foreach (Product product in viewModel.Cart.ProductList)
            {
                currentTotal += product.Price;
            }
            Assert.AreEqual(expectedTotal, currentTotal, 0.001);
        }

        [TestMethod]
        public void TestCartOld()
        {
            //Assert.IsTrue(false);
            var discountMockService = new Mock<IDiscountService>();
            var currentTimeMockService = new Mock<ICurrentTime>();
            currentTimeMockService.Setup(m => m.CurrentTime).Returns(DateTime.Now);
            CartViewModel viewModel = new CartViewModel(discountMockService.Object, currentTimeMockService.Object, DateTime.Now.AddDays(-8));
            Product product = new Product() { Id = "1", Name = "Carote", Category = "verdura", Price = 0.28 };
            viewModel.AddProductToCartCommand.Execute(product);
            Assert.IsTrue(viewModel.Cart.ProductList.Count == 0);
        }
    }
}
