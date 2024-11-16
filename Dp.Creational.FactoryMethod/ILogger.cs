namespace Dp.Creational.FactoryMethod;

internal interface ILogger
{
    /// <summary>
    /// Logs an informational message.
    /// </summary>
    /// <param name="message">The message to be logged.</param>
    void LogInformation(string message);
}
