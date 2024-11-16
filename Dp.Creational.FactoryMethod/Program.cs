namespace Dp.Creational.FactoryMethod;

using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

[ExcludeFromCodeCoverage]
internal static class Program
{
    public static void Main(string[] args)
    {
        var loggerType = GetLoggerType();

        var logger = new LoggerFactory(loggerType).Create();

        logger.LogInformation("Hello world");
    }

    public static LoggerType GetLoggerType()
    {
        var json = File.ReadAllText("settings.json");
        var config = JsonSerializer.Deserialize<Configurations>(json);

        Enum.TryParse(typeof(LoggerType), config?.LoggerType, out var loggerType);

        return loggerType is null ? default : (LoggerType)loggerType;
    }

    private sealed class Configurations
    {
        public string LoggerType { get; set; }
    }
}
