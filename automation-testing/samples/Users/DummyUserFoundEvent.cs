using System;
using System.Collections.Generic;
using System.Text;

namespace samples
{
    class DummyUserFoundEvent : DomainEventBase
    {
        public DummyUserFoundEvent(string email)
        {
            Email = email;
        }

        public string Email { get; }
    }
}
