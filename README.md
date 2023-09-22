# ReproductionFAHostStartupDelay

This is a Simple .Net 6.0 Isolated Function App

Service Bus Trigger has an injected Service named `MyService`

Injecting the Service using the `Program.cs` file like below

```Csharp
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
            //Console.WriteLine("Before the minutes delay");
            //Thread.Sleep(10000);
            //Console.WriteLine("After the minutes delay");
            services.AddScoped<IMyService, MyService>();
        })
        .Build();

        host.Run();
    }
}
```

Interface

```Csharp
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

public  interface IMyService
{
    Task MyServiceMethod();
}
```

Concrete Service Class

```Csharp
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

public class MyService : IMyService
{
    public int MyServiceInt;
    public readonly ILogger<MyService> Ilogger;

    public MyService(ILogger<MyService> _Ilogger)
    {
        Ilogger = _Ilogger;
        Console.WriteLine("MyService Constructor Starting");
        Ilogger.LogInformation("MyService Constructor Starting");
        //Console.WriteLine("Staring Delay");
        //System.Threading.Thread.Sleep(10000);
        //Console.WriteLine("Ending Delay");
        MyServiceInt = 0;
        Ilogger.LogInformation("MyService Constructor Ending");
        Console.WriteLine("MyService Constructor Ending");
    }

    public async Task MyServiceMethod()
    {
        Console.WriteLine("MyServiceMethod has been called!");
        await Task.Delay(1);
    }
}
```
