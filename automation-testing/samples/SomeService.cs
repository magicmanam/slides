using System;
using System.Collections.Generic;
using System.Text;

namespace samples
{
    public class SomeService : ISomeService
    {
        private readonly ICalculator _calculator; // Mutable dependency
        private readonly IEmailSender _emailSender; // Shared and unmanaged dependency

        public SomeService(ICalculator calculator, IEmailSender emailSender, string title = null)
        {
            _calculator = calculator ?? throw new ArgumentNullException();
            _emailSender = emailSender ?? throw new ArgumentNullException();

            Title = title;// Immutable dependency
        }

        // Public property and does not meet client goal immediately
        public string Title { get; set; }

        public void SendEmailWithAntiBotCheck(UserEmail email, int a, int b, int userSum)
        {
            if (_calculator.Sum(a, b) == userSum)
            {
                _emailSender.SendEmail(email.ToString(), Title ?? "No title: " + "Hello, User!");
            }
        }
    }
}
