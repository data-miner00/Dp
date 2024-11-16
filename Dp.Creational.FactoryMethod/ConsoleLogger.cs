namespace Dp.Creational.FactoryMethod;

using System;

internal sealed class ConsoleLogger : ILogger
{
    /// <inheritdoc/>
    public void LogInformation(string message)
    {
        Console.WriteLine("[console]: " + message);
    }
}
