namespace Dp.Creational.Singleton.Example2;

using System;

/// <summary>
/// A dummy logger class to demonstrate the singleton pattern with lazy loading.
/// This will guarantee thread-safe already.
/// </summary>
public sealed class Logger
{
    private static readonly Lazy<Logger> Container = new(() => new Logger());

    private Logger()
    {
        Console.WriteLine("Logger singleton has been created.");
    }

    /// <summary>
    /// Gets the instance of the logger.
    /// </summary>
    public static Logger Instance => Container.Value;

    /// <summary>
    /// Logs an informational message.
    /// </summary>
    /// <param name="message">The message to be logged.</param>
    public void LogInformation(string message)
    {
        Console.WriteLine($"[INFO]: {message}");
    }
}
