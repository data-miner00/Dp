namespace Dp.Creational.AbstractFactory.Example1;

internal sealed class ModernSofa : ISofa
{
    /// <inheritdoc/>
    public int Capacity => 15;

    /// <inheritdoc/>
    public string Color => "metallic silver";

    /// <inheritdoc/>
    public decimal Price => 3888.21m;
}
