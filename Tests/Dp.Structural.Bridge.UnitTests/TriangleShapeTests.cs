namespace Dp.Structural.Bridge.UnitTests;

using Dp.Structural.Bridge;

public sealed class TriangleShapeTests
{
    private readonly RedColor red = new();
    private readonly BlueColor blue = new();

    [Theory]
    [InlineData("red", "I am triangle with red color!")]
    [InlineData("blue", "I am triangle with blue color!")]
    public void ToString_WithDifferentColors_ReturnsExpectedResult(string colorToUse, string expectedToString)
    {
        IColor color = colorToUse == "red" ? this.red : this.blue;

        var triangle = new TriangleShape(color);

        var actual = triangle.ToString();

        Assert.Equal(expectedToString, actual);
    }
}
