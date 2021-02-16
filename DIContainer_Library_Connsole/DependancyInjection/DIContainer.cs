using System;
using System.Collections.Generic;
using System.Text;

namespace DIContainer_Library.DependancyInjection
{
    class DIContainer
    {
       private List<ServiceDescriptor> _serviceDescriptors;
     

        public DIContainer(List<ServiceDescriptor> serviceDescriptors)
        {
            _serviceDescriptors = serviceDescriptors;
        }
        //internal object GetService<T>()
        public T GetService<T>()
        {
            var descriptor = _serviceDescriptors;

            if (descriptor == null)
            {

                throw new Exception();
            }
            if (descriptor != null)
            {
                return default;
                //return (T)descriptor.Implimentation;
                throw new NotImplementedException();
            }

            else 
            { 
            throw new NotImplementedException();
            }
          // return default;

            //throw new NotImplementedException();

        }
    } }
   

