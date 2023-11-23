namespace Dp.Structural.Composite;

internal interface IComponent
{
    IList<IComponent> Children { get; }
}

internal class RegularComponent : IComponent
{
    public string Name = nameof(RegularComponent);
    public IList<IComponent> Children => null;
}

internal class OrdinaryComponent : IComponent
{
    public string Name = nameof(OrdinaryComponent);
    public IList<IComponent> Children => null;
}

internal class CompositeComponent : IComponent
{
    public string Name = nameof(CompositeComponent);
    public IList<IComponent> Children => new List<IComponent>
    {
        new RegularComponent(),
        new OrdinaryComponent(),
        new CompositeComponent(),
    };
}
