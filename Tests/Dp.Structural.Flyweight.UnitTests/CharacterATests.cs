namespace Dp.Structural.Flyweight.UnitTests;

public sealed class CharacterATests
{
    [Theory]
    [InlineData("sans-serif", 400, "Character: a Font Family: sans-serif, Font Weight: 400")]
    [InlineData("serif", 400, "Character: a Font Family: serif, Font Weight: 400")]
    [InlineData("sans-serif", 800, "Character: a Font Family: sans-serif, Font Weight: 800")]
    [InlineData("serif", 800, "Character: a Font Family: serif, Font Weight: 800")]
    public void Constructor_WithDifferentProperties_DifferentStates(string fontFamily, int fontWeight, string expectedState)
    {
        var property = new CharacterProperty
        {
            FontFamily = fontFamily,
            FontWeight = fontWeight,
        };

        var characterA = new CharacterA(property);

        Assert.Equal(expectedState, characterA.State);
    }
}
