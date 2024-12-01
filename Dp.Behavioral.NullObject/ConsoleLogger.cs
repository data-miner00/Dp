namespace Dp.Behavioral.NullObject;

using System;

internal sealed class ConsoleLogger : ILogger
{
    /// <inheritdoc/>
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
