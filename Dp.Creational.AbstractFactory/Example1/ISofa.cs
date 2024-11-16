namespace Dp.Creational.AbstractFactory.Example1;

internal interface ISofa
{
    /// <summary>
    /// Gets the number of people that the sofa can accomodate at once.
    /// </summary>
    int Capacity { get; }

    /// <summary>
    /// Gets the color of the sofa.
    /// </summary>
    string Color { get; }

    /// <summary>
    /// Gets the price of the sofa.
    /// </summary>
    decimal Price { get; }
}
