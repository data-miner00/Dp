namespace Dp.Creational.AbstractFactory.Example1;

internal sealed class ModernFurnitureFactory : IFurnitureFactory
{
    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}
