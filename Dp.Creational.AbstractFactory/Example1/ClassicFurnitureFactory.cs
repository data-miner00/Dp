namespace Dp.Creational.AbstractFactory.Example1;

internal sealed class ClassicFurnitureFactory : IFurnitureFactory
{
    /// <inheritdoc/>
    public ISofa CreateSofa()
    {
        return new ClassicSofa();
    }

    /// <inheritdoc/>
    public ITable CreateTable()
    {
        return new ClassicTable();
    }
}
