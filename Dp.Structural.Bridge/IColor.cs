namespace Dp.Structural.Bridge;

/// <summary>
/// The color interface. In the bridge pattern, this is the implementor.
/// </summary>
internal interface IColor
{
    int Id { get; }

    string Name { get; }
}
