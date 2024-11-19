namespace Dp.Behavioral.Strategy.UnitTests;

public sealed class LocalFileStorageTests
{
    private readonly IFileStorage fileStorage = new LocalFileStorage();

    [Fact]
    public void GetFile_GivenId_ReturnEmptyByteArray()
    {
        var content = this.fileStorage.GetFile("randomId");

        Assert.Empty(content);
    }

    [Fact]
    public void SaveFile_NoError_ReturnTrue()
    {
        var saved = this.fileStorage.SaveFile();

        Assert.True(saved);
    }
}
