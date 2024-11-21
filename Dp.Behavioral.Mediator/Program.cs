namespace Dp.Behavioral.Mediator;

internal static class Program
{
    public static void Main(string[] args)
    {
        var mediator = new LogMediator();

        var infoButton = new InfoComponent(mediator);
        var warnButton = new WarningComponent(mediator);

        infoButton.Click();
        warnButton.Click();
    }
}
