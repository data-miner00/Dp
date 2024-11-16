namespace Dp.Creational.FactoryMethod;

using System;

internal sealed class LoggerFactory : ILoggerFactory
{
    private readonly LoggerType loggerType;

    /// <summary>
    /// Initializes a new instance of the <see cref="LoggerFactory"/> class.
    /// </summary>
    /// <param name="loggerType">The logger type.</param>
    public LoggerFactory(LoggerType loggerType)
    {
        this.loggerType = loggerType;
    }

    /// <inheritdoc/>
    public ILogger Create()
    {
        return this.loggerType switch
        {
            LoggerType.Console => new ConsoleLogger(),
            LoggerType.File => new FileLogger(),
            LoggerType.Cloud => new CloudLogger(),
            _ => throw new NotSupportedException(),
        };
    }
}
