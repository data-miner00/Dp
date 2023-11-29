namespace Dp.Behavioral.Strategy;

internal class S3 : IFileStorage
{
    public byte[] GetFile(string id)
    {
        Console.WriteLine("Getting file from S3...");
        return [];
    }

    public void SaveFile()
    {
        Console.WriteLine("Saving file to S3...");
    }
}
