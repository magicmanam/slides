using System;
using System.Collections.Generic;
using System.Text;

namespace samples
{
    class EmailSender : IEmailSender
    {
        public void SendEmail(string email, string fullBody)
        {
            // I am really sending this email here
        }
    }

    public interface IEmailSender
    {
        // Command: side effect without return value
        void SendEmail(string email, string fullBody);
    }
}
