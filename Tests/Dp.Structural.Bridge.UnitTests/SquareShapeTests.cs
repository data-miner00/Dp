namespace Dp.Structural.Bridge.UnitTests;

using Dp.Structural.Bridge;

public sealed class SquareShapeTests
{
    private readonly RedColor red = new();
    private readonly BlueColor blue = new();

    [Theory]
    [InlineData("red", "I am square with red color!")]
    [InlineData("blue", "I am square with blue color!")]
    public void ToString_WithDifferentColors_ReturnsExpectedResult(string colorToUse, string expectedToString)
    {
        IColor color = colorToUse == "red" ? this.red : this.blue;

        var square = new SquareShape(color);

        var actual = square.ToString();

        Assert.Equal(expectedToString, actual);
    }
}
