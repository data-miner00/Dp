namespace Dp.Creational.Prototype.Seed
{
    internal class FlowerSeed(string type) : Seed
    {
        public string Type { get; } = type;

        public override Seed Copy() => new FlowerSeed(Type);
    }
}
