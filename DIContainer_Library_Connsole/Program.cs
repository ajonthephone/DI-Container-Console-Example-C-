using System;
using DIContainer_Library.DependancyInjection;
namespace DIContainer_Library_Connsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new DIServiceCollection();
          // services.RegisterSingleton<RandomGuidGenerator>();
            services.RegisterSingleton(new RandomGuidGenerator());

            //services.RegisterTransient<ServiceName2>();//remove later
            var container = services.GenerateContainer();
            //var container = new DIContainer(); //remove later
           var service = container.GetService<RandomGuidGenerator>();
            //////var serviceFirst = container.GetService<RandomGuidGenerator>();
            //////var serviceSecond = container.GetService<RandomGuidGenerator>();
            //Console.WriteLine(Guid.NewGuid()); ;
            //Console.WriteLine(serviceFirst.ToString());
            //Console.WriteLine(serviceSecond.ToString());
            Console.WriteLine("Container Created:" + Guid.NewGuid());
            Console.WriteLine("Container Created:" + Guid.NewGuid());
            Console.WriteLine("Container Created:" + Guid.NewGuid());
            Console.WriteLine("Container Created:" + Guid.NewGuid());
            // Console.WriteLine(serviceFirst.RandomGuid);
            //Console.WriteLine(serviceSecond.RandomGuid);

        }
    }
}
