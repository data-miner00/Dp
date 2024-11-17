namespace Dp.Structural.Bridge;

using System;

internal sealed class TriangleShape : IShape
{
    public TriangleShape(IColor color)
    {
        this.Color = color;
    }

    public int Id => 1;

    public string Name => "triangle";

    public IColor Color { get; }

    public override string ToString()
    {
        return $"I am {this.Name} with {this.Color.Name} color!";
    }
}
