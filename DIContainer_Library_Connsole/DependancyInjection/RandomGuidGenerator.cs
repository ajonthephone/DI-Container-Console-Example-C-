using System;
using System.Collections.Generic;
using System.Text;


namespace DIContainer_Library.DependancyInjection
{
     class  RandomGuidGenerator
    {
        public Guid RandomGuid {get;set; } = Guid.NewGuid();
        
    }
}
