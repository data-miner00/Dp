namespace Dp.Behavioral.Mediator;

internal sealed class WarningComponent : Component
{
    public WarningComponent(ILogMediator mediator)
        : base(mediator)
    {
    }

    public override void Click()
    {
        this.mediator.Log("warn", "Warning Button Clicked!");
    }
}
