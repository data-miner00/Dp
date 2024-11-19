namespace Dp.Behavioral.Strategy;

internal static class Program
{
    public static void Main(string[] args)
    {
        IFileStorage fileStorage = new LocalFileStorage();

        fileStorage.GetFile("id");

        _ = fileStorage.SaveFile();
    }
}
