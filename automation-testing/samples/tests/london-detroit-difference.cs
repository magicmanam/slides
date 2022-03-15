using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace samples
{
    [TestClass]
    public class LondonDetroitDifferences
    {
        [TestMethod] // London school of isolation - compare Arrange-sections
        public void DoesNotSendEmailWhenSumIsNotCorrect()
        {
            // Arrange
            var calculatorStub = new Mock<ICalculator>();
            calculatorStub.Setup(x => x.Sum(1, 2)).Returns(3);
            var emailSenderMock = new Mock<IEmailSender>();
            var sut = new SomeService(calculatorStub.Object, emailSenderMock.Object);

            // Act
            sut.SendEmailWithAntiBotCheck(new UserEmail("email"), 1, 2, userSum: 4);

            // Assert
            emailSenderMock.Verify(s => s.SendEmail("email", It.IsAny<string>()), Times.Never);
        }

        [TestMethod] // Detroit school of isolation
        public void SendsEmailWhenSumIsCorrect()
        {
            // Arrange
            var emailSenderMock = new Mock<IEmailSender>();
            var sut = new SomeService(new Calculator(), emailSenderMock.Object);

            // Act
            sut.SendEmailWithAntiBotCheck(new UserEmail("email"), 1, 3, userSum: 4);

            // Assert
            emailSenderMock.Verify(s => s.SendEmail("email", It.IsAny<string>()), Times.Once);
        }
    }
}
