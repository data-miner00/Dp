namespace Dp.Structural.Flyweight
{
    /// <summary>
    /// Extrinsic state should not alter intrinsic state.
    /// </summary>
    internal class Icon
    {
        public Icon(string path)
        {
            // load icon
        }
    }

    internal class IconProvider
    {
        private static IDictionary<string, Icon> icons;

        public static Icon GetIcon(string type)
        {
            if (!icons.ContainsKey(type))
            {
                icons[type] = new Icon(type);
            }

            return icons[type];
        }    
    }

    abstract class Button
    {
        public Icon Icon { get; set; }
    }

    class SettingsButton : Button
    {
        public SettingsButton()
        {
            Icon = IconProvider.GetIcon("settings");
        }
    }

    class SolutionWindow
    {
        SettingsButton settings = new SettingsButton();
    }

    class TerminalWindow
    {
        SettingsButton settings = new SettingsButton();
    }
}
