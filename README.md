# ReproductionFAHostStartupDelay

This is a Simple .Net 6.0 Isolated Function App

Service Bus Trigger has an injected Service named `MyService`

Injecting the Service using the `Program.cs` file like below

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

Interface

```Csharp
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

public  interface IMyService
{
    Task MyServiceMethod();
}
```

