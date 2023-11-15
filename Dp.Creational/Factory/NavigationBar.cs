namespace Dp.Creational.Factory;

public class NavigationBar : Element
{
    protected override Button CreateButton()
    {
        return new Button("Default button");
    }
}

public class AnddoirNavigationBar : Element
{
    protected override Button CreateButton()
    {
        return new Button("Android button");
    }
}
