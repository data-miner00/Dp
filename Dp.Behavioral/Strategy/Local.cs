namespace Dp.Behavioral.Strategy;

internal class Local : IFileStorage
{
    public byte[] GetFile(string id)
    {
        Console.WriteLine("Getting file from local...");
        return [];
    }

    public void SaveFile()
    {
        Console.WriteLine("Saving file to local...");
    }
}
