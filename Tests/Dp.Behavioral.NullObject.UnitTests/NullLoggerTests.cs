namespace Dp.Behavioral.NullObject.UnitTests;

public sealed class NullLoggerTests
{
    [Fact]
    public void Initialize_TypeMatch()
    {
        ILogger logger;

        logger = new NullLogger();

        Assert.NotNull(logger);
        Assert.IsType<NullLogger>(logger);
    }
}
