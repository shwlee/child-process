using ChildService;

// Windows service 로 실행.
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddWindowsService(options =>
{
    options.ServiceName = "Child Process Kill";
});
builder.Services.AddHostedService<Worker>();

IHost host = builder.Build();
host.Run();