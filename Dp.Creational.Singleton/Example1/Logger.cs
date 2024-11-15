namespace Dp.Creational.Singleton.Example1;

using System;

/// <summary>
/// A dummy logger class to demonstrate the singleton pattern.
/// </summary>
public sealed class Logger
{
    private static Logger? instance;

    private Logger()
    {
        Console.WriteLine("Logger singleton has been created.");
    }

    /// <summary>
    /// Gets the instance of the logger.
    /// </summary>
    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }
    }

    /// <summary>
    /// Logs an informational message.
    /// </summary>
    /// <param name="message">The message to be logged.</param>
    public void LogInformation(string message)
    {
        Console.WriteLine($"[INFO]: {message}");
    }
}
