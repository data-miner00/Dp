namespace Dp.Structural.Proxy;

public interface IAbstraction;

internal class Concretion : IAbstraction;

/// <summary>
/// Proxy mostly solves performance/infrastructure problems. Otherwise,
/// decorator may be the better choice. It is not meant for composability.
/// 
/// Example: Lazy loading images
/// </summary>
internal class ConcretionProxy : IAbstraction
{
    // hide concretion, if we inject we already expose it
    private readonly Concretion concretion = new();
}

internal class ConcretionDecorator : IAbstraction
{
    private readonly IAbstraction concretion;

    public ConcretionDecorator(IAbstraction concretion)
    {
        this.concretion = concretion;
    }
}
