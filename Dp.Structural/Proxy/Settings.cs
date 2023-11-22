namespace Dp.Structural.Proxy;

public class Settings : ISettings
{
    private readonly string config;

    public Settings(string config) => this.config = config;

    public string GetConfig() => this.config;
}
