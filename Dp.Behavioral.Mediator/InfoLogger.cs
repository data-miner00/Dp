namespace Dp.Behavioral.Mediator;

using System;

internal sealed class InfoLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("[INFO]: " + message);
    }
}
