using System.Diagnostics;

namespace ChildService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Debugger.Launch();
        
        var appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        var path = Path.Combine(appPath, "../../../../Child/bin/Debug/net7.0/Child.exe");
        var process = new Process();
        process.StartInfo.FileName = path;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.Start();
        
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }
}