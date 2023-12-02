namespace Dp.Creational.UnitTests.Builder.V2;

using Dp.Creational.Builder.V2;

public class GarageTests
{
    private readonly Garage garage = new();

    [Fact]
    public void Garage_ShouldBuildMini()
    {
        var miniBuilder = new MiniBuilder();

        this.garage.Construct(miniBuilder);

        miniBuilder.Car.carType.Should().Be("Mini");
        miniBuilder.Car.parts.Should().HaveCount(2);
        miniBuilder.Car.parts.Should().BeEquivalentTo(new List<string> { "'not a V8'", "'3-door with stripes'" });
    }

    [Fact]
    public void Garage_ShouldBuildBMW()
    {
        var bmwBuilder = new BMWBuilder();

        this.garage.Construct(bmwBuilder);

        bmwBuilder.Car.carType.Should().Be("BMW");
        bmwBuilder.Car.parts.Should().HaveCount(2);
        bmwBuilder.Car.parts.Should().BeEquivalentTo(new List<string> { "'a fancy V8 engine'", "'5-door with metallic finish'" });
    }
}
