using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace samples
{
    [TestClass]
    public class EdgeCases
    {
        [TestMethod] // Assert-free test
        public void SendsGreetingEmail()
        {
            // Arrange
            var calculatorStub = new Mock<ICalculator>();
            var emailSenderMock = new Mock<IEmailSender>();
            var sut = new SomeService(calculatorStub.Object, emailSenderMock.Object);

            // Act
            sut.SendEmailWithAntiBotCheck(new UserEmail("email"), 1, 2, userSum: 4);
        }

        [TestMethod] // Stub examination - lack of resistance to refactoring
        public void SendsEmail_WhenCondition_SendsEmail()
        {
            // Arrange
            var emailSenderMock = new Mock<IEmailSender>();
            var calculatorStub = new Mock<ICalculator>();
            var sut = new SomeService(calculatorStub.Object, emailSenderMock.Object);

            // Act
            sut.SendEmailWithAntiBotCheck(new UserEmail("email"), 1, 3, userSum: 2);

            // Assert
            calculatorStub.Verify(c => c.Sum(1, 3), Times.Once);
        }

        [TestMethod]
        public void TitleGetterWhenOverridenReturnsOverriddenValue()
        {
            // Arrange
            var emailSenderMock = new Mock<IEmailSender>();
            var calculatorStub = new Mock<ICalculator>();
            var sut = new SomeService(calculatorStub.Object, emailSenderMock.Object);

            // Act
            sut.Title = "New title";

            // Assert
            Assert.AreEqual(sut.Title, "New title");
        }
    }
}
