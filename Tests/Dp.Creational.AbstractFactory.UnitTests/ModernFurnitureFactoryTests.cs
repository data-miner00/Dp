namespace Dp.Creational.AbstractFactory.UnitTests;

using Dp.Creational.AbstractFactory.Example1;

public sealed class ModernFurnitureFactoryTests
{
    private readonly IFurnitureFactory factory = new ModernFurnitureFactory();

    [Fact]
    public void CreateTable_CreatesExpectedTable()
    {
        var table = this.factory.CreateTable();

        Assert.IsType<ModernTable>(table);
    }

    [Fact]
    public void CreateSofa_CreatesExpectedSofa()
    {
        var sofa = this.factory.CreateSofa();

        Assert.IsType<ModernSofa>(sofa);
    }
}
