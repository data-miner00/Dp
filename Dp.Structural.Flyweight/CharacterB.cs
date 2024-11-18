﻿namespace Dp.Structural.Flyweight;

internal sealed class CharacterB : ICharacter
{
    // Intrinsic state
    private readonly char character = 'b';

    // Extrinsic state from constructor
    private readonly CharacterProperty property;

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterB"/> class.
    /// </summary>
    /// <param name="property">The character property.</param>
    public CharacterB(CharacterProperty property)
    {
        this.property = property;
    }

    /// <inheritdoc/>
    public string State
    {
        get
        {
            return string.Format(
                "Character: {0} Font Family: {1}, Font Weight: {2}",
                this.character,
                this.property.FontFamily,
                this.property.FontWeight);
        }
    }
}