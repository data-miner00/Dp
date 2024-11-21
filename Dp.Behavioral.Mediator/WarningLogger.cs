namespace Dp.Behavioral.Mediator;

using System;

internal sealed class WarningLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("[WARN]: " + message);
    }
}
