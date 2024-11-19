namespace Dp.Behavioral.Strategy;

internal sealed class S3FileStorage : IFileStorage
{
    /// <inheritdoc/>
    public byte[] GetFile(string id)
    {
        Console.WriteLine("Getting file from S3...");
        return [];
    }

    /// <inheritdoc/>
    public bool SaveFile()
    {
        Console.WriteLine("Saving file to S3...");
        return false;
    }
}
