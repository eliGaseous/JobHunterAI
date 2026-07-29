using JobHunterAI.CLI.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JobHunterAI.CLI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddJobHunterAI(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<AppSettings>(
            configuration.GetSection(AppSettings.SectionName));

        services.AddSingleton<Application>();

        return services;
    }
}