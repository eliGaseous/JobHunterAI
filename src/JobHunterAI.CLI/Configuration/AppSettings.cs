namespace JobHunterAI.CLI.Configuration;

public sealed class AppSettings
{
    public const string SectionName = "Application";

    public string ApplicationName { get; set; } = "JobHunterAI";

    public string Version { get; set; } = "0.2";

    public string Environment { get; set; } = "Development";
}