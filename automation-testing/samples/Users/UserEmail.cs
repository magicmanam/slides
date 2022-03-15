using System;
using System.Collections.Generic;
using System.Text;

namespace samples
{
    public class UserEmail
    {
        private readonly string _email;

        public UserEmail(string email)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }
            // Email Regex here

            _email = email;
        }

        public override string ToString()
        {
            return _email;
        }
    }
}
