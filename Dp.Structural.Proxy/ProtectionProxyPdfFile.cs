namespace Dp.Structural.Proxy;

/// <summary>
/// Protected PDF file.
/// </summary>
internal sealed class ProtectionProxyPdfFile : IPdfFile
{
    private readonly PdfFile pdfFile;
    private readonly string userRole;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProtectionProxyPdfFile"/> class.
    /// </summary>
    /// <param name="fileName">The file name.</param>
    /// <param name="userRole">The user role.</param>
    public ProtectionProxyPdfFile(string fileName, string userRole)
    {
        this.FileName = fileName;
        this.userRole = userRole;
        this.pdfFile = new PdfFile(fileName);
    }

    /// <inheritdoc/>
    public string FileName { get; }

    /// <inheritdoc/>
    public string Content
    {
        get
        {
            if (this.userRole == "admin")
            {
                return this.pdfFile.Content;
            }
            else
            {
                return "You are not authorized to view the content.";
            }
        }
    }
}
