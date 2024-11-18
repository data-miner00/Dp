namespace Dp.Structural.Proxy;

/// <summary>
/// Represents a PDF file. This is the subject in the proxy pattern.
/// </summary>
internal sealed class PdfFile : IPdfFile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PdfFile"/> class.
    /// </summary>
    /// <param name="fileName">The name of the file.</param>
    public PdfFile(string fileName)
    {
        this.FileName = fileName;
        this.LoadPdf();
    }

    /// <inheritdoc/>
    public string FileName { get; }

    /// <inheritdoc/>
    public string Content { get; private set; } = string.Empty;

    private void LoadPdf()
    {
        //Thread.Sleep(300); Simulate huge loading time.

        this.Content = $"Title is {this.FileName}. Huge content!";
    }
}
