namespace Dp.Behavioral.Mediator.UnitTests;

public sealed class WarningComponentTests
{
    [Fact]
    public void Initialize_WithMediator_NoError()
    {
        var warnComponent = new WarningComponent(new LogMediator());

        warnComponent.Click();

        Assert.NotNull(warnComponent);
    }
}
