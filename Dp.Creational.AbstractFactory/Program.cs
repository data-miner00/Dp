namespace Dp.Creational.AbstractFactory;

using System.Diagnostics.CodeAnalysis;
using Dp.Creational.AbstractFactory.Example1;

[ExcludeFromCodeCoverage]
internal static class Program
{
    public static void Main(string[] args)
    {
        IFurnitureFactory factory = new ModernFurnitureFactory();

        ITable table = factory.CreateTable();
        ISofa sofa = factory.CreateSofa();

        Console.WriteLine("Sofa price: " + sofa.Price);
        Console.WriteLine("Table price: " + table.Price);
    }
}
