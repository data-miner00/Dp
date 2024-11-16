namespace Dp.Creational.AbstractFactory.UnitTests;

using Dp.Creational.AbstractFactory.Example1;

public sealed class ClassicFurnitureFactoryTests
{
    private readonly IFurnitureFactory factory = new ClassicFurnitureFactory();

    [Fact]
    public void CreateTable_CreatesExpectedTable()
    {
        var table = this.factory.CreateTable();

        Assert.IsType<ClassicTable>(table);
    }

    [Fact]
    public void CreateSofa_CreatesExpectedSofa()
    {
        var sofa = this.factory.CreateSofa();

        Assert.IsType<ClassicSofa>(sofa);
    }
}
