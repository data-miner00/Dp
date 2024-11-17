namespace Dp.Structural.Bridge;

internal sealed class SquareShape : IShape
{
    public SquareShape(IColor color)
    {
        this.Color = color;
    }

    public int Id => 2;

    public string Name => "square";

    public IColor Color { get; }

    public override string ToString()
    {
        return $"I am {this.Name} with {this.Color.Name} color!";
    }
}
