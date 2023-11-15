namespace Dp.Creational.Factory;

/// <summary>
/// If there are 2 places that requires identical button, use factory.
/// </summary>
public static class ButtonFactory
{
    public static Button CreateDefault()
    {
        return new Button("default");
    }
}
