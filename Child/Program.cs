// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("Start child!!!!!!!!!!!!!!!!!!!!!!");
Debug.WriteLine("Start child!!!!!!!!!!!!!!!!!!!!!!");
Trace.WriteLine("Start child!!!!!!!!!!!!!!!!!!!!!!");

for (var i = 0; i < 30; i++)
{
    await Task.Delay(1000);
    Console.WriteLine($"Take : {i}");
    Debug.WriteLine($"Take : {i}");
    Trace.WriteLine($"Take : {i}");
}

Console.WriteLine("Child Done!!!!!!!!!!!!!!!!!!!!!!!!!!");
Debug.WriteLine("Child Done!!!!!!!!!!!!!!!!!!!!!!!!!!");
Trace.WriteLine("Child Done!!!!!!!!!!!!!!!!!!!!!!!!!!");