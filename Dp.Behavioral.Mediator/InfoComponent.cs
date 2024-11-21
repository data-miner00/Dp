namespace Dp.Behavioral.Mediator;

internal sealed class InfoComponent : Component
{
    public InfoComponent(ILogMediator mediator)
        : base(mediator)
    {
    }

    public override void Click()
    {
        this.mediator.Log("info", "Info button clicked!");
    }
}
