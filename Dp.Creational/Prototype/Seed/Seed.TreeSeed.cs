namespace Dp.Creational.Prototype.Seed
{
    internal class TreeSeed(string type) : Seed
    {
        public string Type { get; } = type;

        public override Seed Copy() => new TreeSeed(Type);
    }
}
