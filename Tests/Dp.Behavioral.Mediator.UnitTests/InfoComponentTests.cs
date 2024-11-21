namespace Dp.Behavioral.Mediator.UnitTests;

public sealed class InfoComponentTests
{
    [Fact]
    public void Initialize_WithMediator_NoError()
    {
        var infoComponent = new InfoComponent(new LogMediator());

        infoComponent.Click();

        Assert.NotNull(infoComponent);
    }
}
