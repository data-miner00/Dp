namespace Dp.Behavioral.NullObject.UnitTests;

public sealed class ConsoleLoggerTests
{
    [Fact]
    public void Initialize_TypeMatch()
    {
        ILogger logger;

        logger = new ConsoleLogger();

        Assert.NotNull(logger);
        Assert.IsType<ConsoleLogger>(logger);
    }
}
