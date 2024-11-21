namespace Dp.Behavioral.Mediator;

using System;

internal sealed class LogMediator : ILogMediator
{
    private readonly ILogger infoLogger = new InfoLogger();
    private readonly ILogger warnLogger = new WarningLogger();

    public void Log(string type, string message)
    {
        if (type.Equals("info", StringComparison.OrdinalIgnoreCase))
        {
            this.infoLogger.Log(message);
        }
        else if (type.Equals("warn", StringComparison.OrdinalIgnoreCase))
        {
            this.warnLogger.Log(message);
        }
        else
        {
            throw new NotSupportedException("Method provided not supported.");
        }
    }
}
