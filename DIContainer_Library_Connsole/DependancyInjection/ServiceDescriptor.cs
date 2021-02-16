using System;
using System.Collections.Generic;
using System.Text;

namespace DIContainer_Library.DependancyInjection
{
    class ServiceDescriptor
    {
        //public Type ServiceType { get; set; }
        public Type ServiceType { get; }
        // public object ServiceImplimentation { get; set; }
        public object ServiceImplimentation { get; }

        public ServiceLifetime Lifetime { get; }

        public ServiceDescriptor(object implemetation, ServiceLifetime lifetime)
        {
            ServiceType = implemetation.GetType();
            ServiceImplimentation = implemetation;
            Lifetime = lifetime;
        }

    }
}
    //  8:10 in the video

