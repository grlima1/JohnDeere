// See https://aka.ms/new-console-template for more information
using IoC;
using JohnDeere.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

// Registering services from IoC
builder.Services.AddServices();

// Register your hosted service
builder.Services.AddHostedService<JDBackgroundService>();

IHost host = builder.Build();
host.Run();


