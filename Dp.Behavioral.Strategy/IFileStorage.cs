namespace Dp.Behavioral.Strategy;

/// <summary>
/// Strategy pattern is simple and common. Basically, when we have different ways to perform an action,
/// the different options is considered as a strategy.
/// </summary>
internal interface IFileStorage
{
    /// <summary>
    /// Reads the file into bytes.
    /// </summary>
    /// <param name="id">The id of the file.</param>
    /// <returns>The bytes of the file.</returns>
    byte[] GetFile(string id);

    /// <summary>
    /// Saves the file.
    /// </summary>
    /// <returns>The flag indicating success or not.</returns>
    bool SaveFile();
}
