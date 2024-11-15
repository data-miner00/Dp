namespace Dp.Creational.Singleton.UnitTests;

using Dp.Creational.Singleton.Example1;

public class Example1Tests
{
    [Fact]
    public void Getter_InstanceNotNull()
    {
        var loggerRef1 = Logger.Instance;

        Assert.NotNull(loggerRef1);
    }

    [Fact]
    public void Getter_AlwaysReturnSameInstance()
    {
        var loggerRef1 = Logger.Instance;
        var loggerRef2 = Logger.Instance;
        var loggerRef3 = Logger.Instance;

        Assert.Same(loggerRef1, loggerRef2);
        Assert.Same(loggerRef1, loggerRef3);
    }
}
