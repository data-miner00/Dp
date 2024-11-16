namespace Dp.Creational.AbstractFactory.Example1;

internal interface IFurnitureFactory
{
    /// <summary>
    /// Creates the table.
    /// </summary>
    /// <returns>The table.</returns>
    ITable CreateTable();

    /// <summary>
    /// Creates the sofa.
    /// </summary>
    /// <returns>The sofa.</returns>
    ISofa CreateSofa();
}
