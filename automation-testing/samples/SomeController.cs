using System;
using System.Collections.Generic;
using System.Text;

namespace samples
{
    class SomeController
    {
        private readonly ISomeService _someService;
        private readonly DomainEventsDispatcher _domainEventsDispatcher;

        public SomeController(ISomeService someService, DomainEventsDispatcher domainEventsDispatcher)
        {
            _someService = someService ?? throw new ArgumentNullException();
            _domainEventsDispatcher = domainEventsDispatcher;
        }

        public void SomeUseCase(int a, int b, int sum)
        {
            _someService.SendEmailWithAntiBotCheck(new UserEmail("hard@coded.user"), a, b, sum);            
        }
    }
}
