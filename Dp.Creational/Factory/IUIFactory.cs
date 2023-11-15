namespace Dp.Creational.Factory;

/// <summary>
/// Used when we want to offset some options externally to control the object built.
/// </summary>
public interface IUIFactory
{
    public Button CreateButton();
}
