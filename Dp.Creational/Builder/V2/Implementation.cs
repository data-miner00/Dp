namespace Dp.Creational.Builder.V2;

using System.Text;

internal class Car
{
    public readonly List<string> parts = new();
    public readonly string carType;

    public Car(string carType)
    {
        this.carType = carType;
    }

    public void AddPart(string part)
    {
        this.parts.Add(part);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        foreach (var part in this.parts)
        {
            sb.Append($"Car of type {this.carType} has part {part}");
        }

        return sb.ToString();
    }
}

abstract class CarBuilder
{
    public Car Car { get; private set; }

    public CarBuilder(string carType)
    {
        this.Car = new Car(carType);
    }

    public abstract void BuildEngine();

    public abstract void BuildFrame();
}

/// <summary>
/// Concrete builder
/// </summary>
class MiniBuilder : CarBuilder
{
    public MiniBuilder() : base("Mini")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("'not a V8'");
    }

    public override void BuildFrame()
    {
        Car.AddPart("'3-door with stripes'");
    }
}

/// <summary>
/// Concrete builder
/// </summary>
class BMWBuilder : CarBuilder
{
    public BMWBuilder() : base("BMW") { }

    public override void BuildEngine()
    {
        Car.AddPart("'a fancy V8 engine'");
    }

    public override void BuildFrame()
    {
        Car.AddPart("'5-door with metallic finish'");
    }
}

/// <summary>
/// Director
/// </summary>
class Garage
{
    private CarBuilder? builder;

    public Garage()
    {
    }

    public void Construct(CarBuilder builder)
    {
        this.builder = builder;

        this.builder.BuildEngine();
        this.builder.BuildFrame();
    }
}
