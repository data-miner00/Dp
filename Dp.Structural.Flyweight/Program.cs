namespace Dp.Structural.Flyweight;

internal static class Program
{
    public static void Main(string[] args)
    {
        var sansSerifNormalProperty = new CharacterProperty
        {
            FontFamily = "sans-serif",
            FontWeight = 400,
        };

        var serifNormalProperty = new CharacterProperty
        {
            FontFamily = "serif",
            FontWeight = 400,
        };

        var sansSerifBoldProperty = new CharacterProperty
        {
            FontFamily = "sans-serif",
            FontWeight = 800,
        };

        var serifBoldProperty = new CharacterProperty
        {
            FontFamily = "serif",
            FontWeight = 800,
        };

        var sansSerifNormalCharacterA = new CharacterA(sansSerifNormalProperty);
        var serifNormalCharacterA = new CharacterA(serifNormalProperty);
        var sansSerifBoldCharacterA = new CharacterA(sansSerifBoldProperty);
        var serifBoldCharacterA = new CharacterA(serifBoldProperty);

        var sansSerifNormalCharacterB = new CharacterB(sansSerifNormalProperty);
        var serifNormalCharacterB = new CharacterB(serifNormalProperty);
        var sansSerifBoldCharacterB = new CharacterB(sansSerifBoldProperty);
        var serifBoldCharacterB = new CharacterB(serifBoldProperty);

        Console.WriteLine('-' * 100);
        Console.WriteLine(sansSerifNormalCharacterA.State);
        Console.WriteLine(serifNormalCharacterA.State);
        Console.WriteLine(sansSerifBoldCharacterA.State);
        Console.WriteLine(serifBoldCharacterA.State);

        Console.WriteLine('-' * 100);
        Console.WriteLine(sansSerifNormalCharacterB.State);
        Console.WriteLine(serifNormalCharacterB.State);
        Console.WriteLine(sansSerifBoldCharacterB.State);
        Console.WriteLine(serifBoldCharacterB.State);
    }
}
