namespace Dp.Behavioral.Strategy.UnitTests;

public sealed class S3FileStorageTests
{
    private readonly IFileStorage fileStorage = new S3FileStorage();

    [Fact]
    public void GetFile_GivenId_ReturnEmptyArray()
    {
        var content = this.fileStorage.GetFile("random file");

        Assert.Empty(content);
    }

    [Fact]
    public void SaveFile_NoError_ReturnFalse()
    {
        var saved = this.fileStorage.SaveFile();

        Assert.False(saved);
    }
}
