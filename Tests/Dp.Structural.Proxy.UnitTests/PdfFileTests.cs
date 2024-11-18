namespace Dp.Structural.Proxy.UnitTests;

public sealed class PdfFileTests
{
    private const string FileName = "myfile.pdf";
    private static readonly string FileContent = $"Title is {FileName}. Huge content!";

    [Fact]
    public void GetName_ProvidedName_ExpectNameMatch()
    {
        var pdfFile = new PdfFile(FileName);

        Assert.Equal(FileName, pdfFile.FileName);
    }

    [Fact]
    public void GetContent_ProvidedName_ExpectContentMatch()
    {
        var pdfFile = new PdfFile(FileName);

        Assert.Equal(FileContent, pdfFile.Content);
    }
}
