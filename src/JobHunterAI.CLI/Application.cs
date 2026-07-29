using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using JobHunterAI.CLI.Configuration;
using System.Threading.Tasks;
using System;
namespace JobHunterAI.CLI;

public sealed class Application
{
    private readonly ILogger<Application> _logger;
    private readonly AppSettings _settings;

    public Application(
        ILogger<Application> logger,
        IOptions<AppSettings> settings)
    {
        _logger = logger;
        _settings = settings.Value;
    }

    public Task RunAsync()
    {
        Console.WriteLine("========================================");
        Console.WriteLine($"        {_settings.ApplicationName} {_settings.Version}");
        Console.WriteLine("========================================");
        Console.WriteLine();

        _logger.LogInformation("Application started.");

        Console.WriteLine("Configuration loaded.");
        Console.WriteLine();
        Console.WriteLine("JobHunterAI is ready.");
        Console.WriteLine();

        return Task.CompletedTask;
    }
}