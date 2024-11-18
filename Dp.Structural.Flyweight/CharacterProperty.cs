namespace Dp.Structural.Flyweight;

internal sealed class CharacterProperty
{
    public CharacterProperty()
    {
        // This is an expensive class.
    }

    /// <summary>
    /// Gets the font family of the character.
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Gets the font weight of the character.
    /// </summary>
    public int FontWeight { get; set; }
}
