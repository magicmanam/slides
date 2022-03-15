using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace samples
{
    class DomainEventsDispatcher
    {
        private IDomainEventHandler<DomainEventBase>[] _domainEventHandlers;

        public DomainEventsDispatcher(params IDomainEventHandler<DomainEventBase>[] domainEventHandlers)
        {
            _domainEventHandlers = domainEventHandlers ?? new IDomainEventHandler<DomainEventBase>[] { };
        }

        public void HandleEvent(DomainEventBase domainEvent)
        {
            foreach (var handler in _domainEventHandlers)
            {
                handler.HandleEvent(domainEvent);
            }
        }
    }
}
