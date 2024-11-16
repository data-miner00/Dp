namespace Dp.Creational.AbstractFactory.Example1;

internal interface ITable
{
    /// <summary>
    /// Gets the number of legs that the table has.
    /// </summary>
    int Legs { get; }

    /// <summary>
    /// Gets the height in CM.
    /// </summary>
    int Height { get; }

    /// <summary>
    /// Gets the width in CM.
    /// </summary>
    int Width { get; }

    /// <summary>
    /// Gets the price of the table.
    /// </summary>
    decimal Price { get; }
}
