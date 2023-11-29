namespace Dp.Behavioral.Strategy;

/// <summary>
/// Strategy pattern is simple and common. Basically, when we have different ways to perform an action,
/// the different options is considered as a strategy.
/// </summary>
internal interface IFileStorage
{
    byte[] GetFile(string id);
    void SaveFile();
}
