using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace samples
{
    [TestClass]
    public class TrivialTests
    {
        [TestMethod] // There are no requirements to check constructor's arguments
        public void OnCreation_WhenCalculatorIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            ICalculator calculator = null;
            var emailSenderMock = new Mock<IEmailSender>();

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new SomeService(calculator, emailSenderMock.Object));
        }
    }
}
