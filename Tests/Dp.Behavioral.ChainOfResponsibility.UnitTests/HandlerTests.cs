namespace Dp.Behavioral.ChainOfResponsibility.UnitTests;

public sealed class HandlerTests
{
    [Fact]
    public void InitializeHandlers_NoError_NotNull()
    {
        var handler = new InitialHandler(new MiddleHandler(new FinalHandler()));

        Assert.NotNull(handler);
    }
}
