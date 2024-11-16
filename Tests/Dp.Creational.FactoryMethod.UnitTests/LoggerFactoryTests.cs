namespace Dp.Creational.FactoryMethod.UnitTests;

using Dp.Creational.FactoryMethod;

public sealed class LoggerFactoryTests
{
    [Fact]
    public void Create_UnsupportedLogger_Throws()
    {
        Assert.Throws<NotSupportedException>(() => new LoggerFactory(default).Create());
    }

    [Theory]
    [InlineData(LoggerType.Console, typeof(ConsoleLogger))]
    [InlineData(LoggerType.File, typeof(FileLogger))]
    [InlineData(LoggerType.Cloud, typeof(CloudLogger))]
    internal void Create_SupportedLogger_GetsCorrectInstance(LoggerType loggerTypeEnum, Type expectedType)
    {
        var factory = new LoggerFactory(loggerTypeEnum);

        var actual = factory.Create();

        Assert.IsType(expectedType, actual);
    }
}
