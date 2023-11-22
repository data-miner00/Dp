namespace Dp.Structural.Proxy;

public class AuthService
{
    public bool Allowed => false;
}

public class ProtectedSettings : ISettings
{
    private readonly AuthService auth;
    private readonly Settings settings;

    public ProtectedSettings(AuthService auth)
    {
        this.auth = auth;
        this.settings = new Settings("config");
    }

    public string GetConfig()
    {
        if (!this.auth.Allowed)
        {
            throw new InvalidOperationException("not allowed");
        }

        return this.settings.GetConfig();
    }
}
