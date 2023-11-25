namespace Dp.Behavioral.ChainOfResponsibility;

internal class IntegratedDevEnv(IKeyHandler keyHandler) : IKeyHandler
{
    private readonly IKeyHandler keyHandler = keyHandler;

    public void HandleKey(string key)
    {
        if (key == "Ctrl+F")
        {
            Console.WriteLine("Full Search");
        }
        else if (key == "Alt+F4")
        {
            Console.WriteLine("Close Application?");
        }
        else
        {
            this.keyHandler.HandleKey(key);
        }
    }
}
