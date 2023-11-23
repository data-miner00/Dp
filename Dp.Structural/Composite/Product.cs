namespace Dp.Structural.Composite
{
    internal abstract class Product
    {
        public List<Product> Components { get; set; } = [];
    }

    internal class Table : Product
    {
        public Table()
        {
            Components.Add(new Legs());
            Components.Add(new Top());
            Components.Add(new Screws());
        }
    }
    
    internal class Top : Product;

    internal class Legs : Product
    {
        public Legs()
        {
            Components.Add(new Feet());
            Components.Add(new Padding());
            Components.Add(new Screws());
        }
    }

    internal class Feet : Product;

    internal class Screws : Product;

    internal class Padding : Product;
}
