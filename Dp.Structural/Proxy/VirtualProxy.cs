namespace Dp.Structural.Proxy;

internal class LazyRemoteSettings : ISettings
{
    private ISettings settings;

    public LazyRemoteSettings(string address)
    {
        // prepare some http/db
    }

    public string GetConfig()
    {
        if (this.settings is null)
        {
            this.settings = new Settings("config");
        }

        return this.settings.GetConfig();
    }
}
