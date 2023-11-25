namespace Dp.Behavioral.ChainOfResponsibility;

internal class CodeSelection(IKeyHandler keyHandler) : IKeyHandler
{
    private readonly IKeyHandler keyHandler = keyHandler;

    public void HandleKey(string key)
    {
        if (key == "Ctrl+F")
        {
            Console.WriteLine("Selection Search");
        }
        else
        {
            this.keyHandler.HandleKey(key);
        }
    }
}
