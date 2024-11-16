namespace Dp.Creational.AbstractFactory.Example1;

internal sealed class ClassicSofa : ISofa
{
    /// <inheritdoc/>
    public int Capacity => 4;

    /// <inheritdoc/>
    public string Color => "dark gray";

    /// <inheritdoc/>
    public decimal Price => 200.23m;
}
