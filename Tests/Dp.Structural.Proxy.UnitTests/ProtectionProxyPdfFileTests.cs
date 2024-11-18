namespace Dp.Structural.Proxy.UnitTests;

public sealed class ProtectionProxyPdfFileTests
{
    private const string Admin = "admin";
    private const string User = "user";
    private const string FileName = "myfile.pdf";
    private const string UnauthorizedMessage = "You are not authorized to view the content.";
    private static readonly string FileContent = $"Title is {FileName}. Huge content!";

    [Fact]
    public void GetName_ProvidedName_ExpectNameMatch()
    {
        var pdfFile = new ProtectionProxyPdfFile(FileName, Admin);

        Assert.Equal(FileName, pdfFile.FileName);
    }

    [Fact]
    public void GetContent_ProvidedNameAndIsAdmin_ExpectContentMatch()
    {
        var pdfFile = new ProtectionProxyPdfFile(FileName, Admin);

        Assert.Equal(FileContent, pdfFile.Content);
    }

    [Fact]
    public void GetContent_ProvidedNameAndIsUser_Unauthorized()
    {
        var pdfFile = new ProtectionProxyPdfFile(FileName, User);

        Assert.Equal(UnauthorizedMessage, pdfFile.Content);
    }
}
