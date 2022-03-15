using System;
using System.Collections.Generic;
using System.Text;

namespace samples.Users
{
    public class User
    {
        public IList<DomainEventBase> DomainEvents = new List<DomainEventBase>();

        public UserId Id { get; set; }

        public UserEmail Email { get; set; }
    }
}
