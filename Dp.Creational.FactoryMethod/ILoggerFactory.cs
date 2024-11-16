namespace Dp.Creational.FactoryMethod;

internal interface ILoggerFactory
{
    /// <summary>
    /// Creates an instance of the logger.
    /// </summary>
    /// <returns>The logger.</returns>
    ILogger Create();
}
