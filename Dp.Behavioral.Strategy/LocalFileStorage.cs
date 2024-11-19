namespace Dp.Behavioral.Strategy;

internal class LocalFileStorage : IFileStorage
{
    /// <inheritdoc/>
    public byte[] GetFile(string id)
    {
        Console.WriteLine("Getting file from local...");

        return [];
    }

    /// <inheritdoc/>
    public bool SaveFile()
    {
        Console.WriteLine("Saving file to local...");

        return true;
    }
}
