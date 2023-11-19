namespace Dp.Creational.Prototype.Seed
{
    internal class GrassSeed(string type) : Seed
    {
        public string Type { get; } = type;

        public override Seed Copy() => new GrassSeed(Type);
    }
}
