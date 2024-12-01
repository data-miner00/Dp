namespace Dp.Behavioral.NullObject;

internal sealed class NullLogger : ILogger
{
    /// <inheritdoc/>
    public void Log(string message)
    {
        // Do nothing
    }
}
