// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

var _quit = new ManualResetEvent(false);

Console.WriteLine("Parent~~~~~~~~~~~~~~~~~!");

var path = "../../../../Child/bin/Debug/net7.0/Child.exe";
var process = new Process();
process.StartInfo.FileName = path;
process.StartInfo.UseShellExecute = false;
process.StartInfo.RedirectStandardOutput = true;
process.Start();

Console.WriteLine("Child open!");

Console.CancelKeyPress += (sender, e) => {
    _quit.Set();
    e.Cancel = true;
};

_quit.WaitOne();

Console.WriteLine("Close!~~~~~~~~~~~~~~~~");