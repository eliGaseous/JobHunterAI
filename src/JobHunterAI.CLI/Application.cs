using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;

namespace JobHunterAI.CLI;

public class Application
{
    private readonly ILogger<Application> _logger;

    public Application(ILogger<Application> logger)
    {
        _logger = logger;
    }

    public Task RunAsync()
    {
        _logger.LogInformation("Application started successfully.");

        Console.WriteLine();
        Console.WriteLine("JobHunterAI is ready.");
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(true);

        return Task.CompletedTask;
    }
}