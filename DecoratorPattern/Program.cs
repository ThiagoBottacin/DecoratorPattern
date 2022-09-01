using Microsoft.Extensions.DependencyInjection;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new Printer();
            IPrinter decorator = new UpperPrinter(printer);
            
            decorator.Print("hello world");
        }

        // static void Main(string[] args)
        // {
        //     var serviceCollection = new ServiceCollection();
        //     ConfigureServices(serviceCollection);
        //     var serviceProvider = serviceCollection.BuildServiceProvider();
        //     
        //     var decorator = serviceProvider.GetRequiredService<IPrinter>();
        //     
        //     decorator.Print("hello world");
        // }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<Printer>();
            services.AddTransient<IPrinter>(provider => 
                new UpperPrinter(provider.GetRequiredService<Printer>()));
            
            // services.AddTransient<IPrinter, Printer>();
            // services.Decorate<IPrinter,UpperPrinter>();
        }
    }
}
