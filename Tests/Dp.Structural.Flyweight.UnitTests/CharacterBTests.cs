namespace Dp.Structural.Flyweight.UnitTests;

public sealed class CharacterBTests
{
    [Theory]
    [InlineData("sans-serif", 400, "Character: b Font Family: sans-serif, Font Weight: 400")]
    [InlineData("serif", 400, "Character: b Font Family: serif, Font Weight: 400")]
    [InlineData("sans-serif", 800, "Character: b Font Family: sans-serif, Font Weight: 800")]
    [InlineData("serif", 800, "Character: b Font Family: serif, Font Weight: 800")]
    public void Constructor_WithDifferentProperties_DifferentStates(string fontFamily, int fontWeight, string expectedState)
    {
        var property = new CharacterProperty
        {
            FontFamily = fontFamily,
            FontWeight = fontWeight,
        };

        var characterB = new CharacterB(property);

        Assert.Equal(expectedState, characterB.State);
    }
}
