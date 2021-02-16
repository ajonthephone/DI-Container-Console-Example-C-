using System;
using System.Collections.Generic;
using System.Text;

namespace DIContainer_Library.DependancyInjection
{
    class DIServiceCollection
    {
        private List<ServiceDescriptor> _serviceDescriptors = new List<ServiceDescriptor>();
        public Guid RegisterSingleton<T>()
        {
          // throw new NotImplementedException();
           return Guid.NewGuid();
        }


        public Guid RegisterSingleton<TService>(TService implimentation)
        {
            _serviceDescriptors.Add(item: new ServiceDescriptor(implimentation, ServiceLifetime.Singleton));
            // throw new NotImplementedException();
            return Guid.NewGuid();
        }
        public DIContainer GenerateContainer()
        {

            return new DIContainer(_serviceDescriptors);
           // return null; ///remove later
            //  throw new NotImplementedException();
        }

        internal T GetService<T>()
        {

           throw new NotImplementedException();
     
        }


    }

}
