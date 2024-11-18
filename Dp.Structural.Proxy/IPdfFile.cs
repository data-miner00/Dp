namespace Dp.Structural.Proxy;

/// <summary>
/// The interface for a PDF file.
/// </summary>
internal interface IPdfFile
{
    /// <summary>
    /// Gets the name of the file.
    /// </summary>
    string FileName { get; }

    /// <summary>
    /// Gets the content of the file.
    /// </summary>
    string Content { get; }
}
