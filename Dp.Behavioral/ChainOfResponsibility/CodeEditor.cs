namespace Dp.Behavioral.ChainOfResponsibility;

internal class CodeEditor(IKeyHandler keyHandler) : IKeyHandler
{
    private readonly IKeyHandler keyHandler = keyHandler;

    public void HandleKey(string key)
    {
        if (key == "Ctrl+F")
        {
            Console.WriteLine("Local Search");
        }
        else
        {
            this.keyHandler.HandleKey(key);
        }
    }
}
