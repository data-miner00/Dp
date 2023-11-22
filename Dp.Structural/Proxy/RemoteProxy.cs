namespace Dp.Structural.Proxy;

/// <summary>
/// Remote proxy decides how to get info.
/// </summary>
public class RemoteSettings : ISettings
{
    private Settings config;

    public RemoteSettings(string address)
    {
        // fetch from appsettings/db/registry etc ...
        this.config = new Settings(address);
    }

    public string GetConfig()
    {
        return this.config.GetConfig();
    }
}
