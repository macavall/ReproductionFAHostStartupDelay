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