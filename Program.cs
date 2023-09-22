using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        var host = new HostBuilder()
        .ConfigureFunctionsWorkerDefaults()
        .ConfigureServices(services =>
        {
            //Console.WriteLine("Before the delay");
            //Thread.Sleep(10000);
            //Console.WriteLine("After the delay");
            services.AddScoped<IMyService, MyService>();
            services.AddScoped<MyService2>();
        })
        .Build();

        host.Run();
    }
}