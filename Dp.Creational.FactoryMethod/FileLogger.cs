namespace Dp.Creational.FactoryMethod;

using System;

internal sealed class FileLogger : ILogger
{
    /// <inheritdoc/>
    public void LogInformation(string message)
    {
        Console.WriteLine("[file]: " + message);
    }
}
