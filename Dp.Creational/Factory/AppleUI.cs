namespace Dp.Creational.Factory
{
    public class AppleUI : IUIFactory
    {
        public Button CreateButton()
        {
            return new Button("Apple");
        }
    }
}
