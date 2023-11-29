namespace Dp.Behavioral.Strategy;

internal class Bespoke : IFileStorage
{
    public byte[] GetFile(string id)
    {
        Console.WriteLine("Getting file from bespoke storage...");
        return [];
    }

    public void SaveFile()
    {
        Console.WriteLine("Saving file to bespoke storage...");
    }
}
