using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

public class MyService2// : IMyService2
{
    public int MyServiceInt;
    //public readonly ILogger<MyService> Ilogger;

    public MyService2()//ILogger<MyService> _Ilogger)
    {
        //Ilogger = _Ilogger;
        Console.WriteLine("MyService Constructor Starting");
        //Ilogger.LogInformation("MyService Constructor Starting");
        //Console.WriteLine("Starting Delay");
        //System.Threading.Thread.Sleep(10000);
        //Console.WriteLine("Ending Delay");
        MyServiceInt = 0;
        //Ilogger.LogInformation("MyService Constructor Ending");
        Console.WriteLine("MyService Constructor Ending");
    }

    public async Task MyServiceMethod()
    {
        Console.WriteLine("MyServiceMethod has been called!");
        await Task.Delay(1);
    }
}