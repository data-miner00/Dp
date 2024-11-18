namespace Dp.Structural.Proxy;

using System;

internal sealed class VirtualProxyPdfFile : IPdfFile
{
    private readonly Lazy<IPdfFile> pdfFileLazy;

    public VirtualProxyPdfFile(string fileName)
    {
        this.FileName = fileName;
        this.pdfFileLazy = new Lazy<IPdfFile>(() => new PdfFile(fileName));
    }

    public string FileName { get; }

    public string Content => this.pdfFileLazy.Value.Content;
}
