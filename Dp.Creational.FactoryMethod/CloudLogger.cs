namespace Dp.Creational.FactoryMethod;

using System;

internal sealed class CloudLogger : ILogger
{
    /// <inheritdoc/>
    public void LogInformation(string message)
    {
        Console.WriteLine("[cloud]: " + message);
    }
}
