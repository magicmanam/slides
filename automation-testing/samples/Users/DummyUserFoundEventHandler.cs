using System;
using System.Collections.Generic;
using System.Text;

namespace samples
{
    class DummyUserFoundEventHandler : IDomainEventHandler<DummyUserFoundEvent>
    {
        public void HandleEvent(DummyUserFoundEvent domainEvent)
        {
            Console.WriteLine("Notify him !!!");
        }
    }

    public interface IDomainEventHandler<T> where T : DomainEventBase
    {
        void HandleEvent(T domainEvent);
    }
}
