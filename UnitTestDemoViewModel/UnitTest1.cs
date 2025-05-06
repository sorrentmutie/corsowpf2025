using DemoUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestDemoViewModel
{
    [TestClass]
    public class LoginViewModelTests
    {
        [TestMethod]
        public void LoginTest()
        {
            // AAA
            // Arrange
            var mockService = new Mock<IAuthService>();
            mockService.Setup(m => m.Login("testuser", "password")).Returns(true);
            var loginViewModel = new LoginViewModel(mockService.Object);
            loginViewModel.Username = "testuser";
            loginViewModel.Password = "password";
            // Act
            loginViewModel.LoginCommand.Execute(null);
            // Asserzione
            Assert.IsTrue(loginViewModel.IsLoggedIn);
        }
    }
}
