using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;

namespace JobHunterAI.CLI;

internal class Program
{
    public static async Task Main(string[] args)
    {
        using IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
            })
            .ConfigureServices(services =>
            {
                services.AddSingleton<Application>();
            })
            .Build();

        Console.WriteLine("========================================");
        Console.WriteLine("          JobHunterAI v0.1");
        Console.WriteLine("========================================");
        Console.WriteLine();

        var application = host.Services.GetRequiredService<Application>();

        await application.RunAsync();
    }
}