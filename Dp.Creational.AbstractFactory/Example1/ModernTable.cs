namespace Dp.Creational.AbstractFactory.Example1;

internal sealed class ModernTable : ITable
{
    /// <inheritdoc />
    public int Legs => 2;

    /// <inheritdoc />
    public int Height => 66;

    /// <inheritdoc />
    public int Width => 305;

    /// <inheritdoc />
    public decimal Price => 1066.63m;
}
