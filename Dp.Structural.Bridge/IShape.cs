namespace Dp.Structural.Bridge;

/// <summary>
/// The shape interface. In the bridge pattern, this is the abstraction.
/// </summary>
internal interface IShape
{
    int Id { get; }

    string Name { get; }

    IColor Color { get; }
}
