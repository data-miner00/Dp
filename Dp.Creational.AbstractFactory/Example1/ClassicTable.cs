namespace Dp.Creational.AbstractFactory.Example1;

internal sealed class ClassicTable : ITable
{
    /// <inheritdoc />
    public int Legs => 4;

    /// <inheritdoc />
    public int Height => 50;

    /// <inheritdoc />
    public int Width => 200;

    /// <inheritdoc />
    public decimal Price => 60.30m;
}
