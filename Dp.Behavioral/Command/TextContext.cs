namespace Dp.Behavioral.Command;

/// <summary>
/// With commands pattern, it is seperated to 3 parts: Receiver, action and trigger.
/// </summary>
internal interface ICommand
{
    void Execute();
}

internal class TextContext
{
    public void HighlightText()
    {
        Console.WriteLine("Highlight text");
    }

    public void BoldText()
    {
        Console.WriteLine("Bolding text");
    }
}

internal class DynamicCommand<T>(T receiver, Action<T> action) : ICommand
{
    private readonly T receiver = receiver;

    private readonly Action<T> action = action;

    public void Execute()
    {
        this.action(this.receiver);
    }
}

internal class Button(ICommand command)
{
    private readonly ICommand command = command;

    public void Click() => this.command.Execute();
}

internal static class Usage
{
    public static void Main()
    {
        var textContext = new TextContext();
        var command1 = new DynamicCommand<TextContext>(textContext, tc => tc.HighlightText());
        var command2 = new DynamicCommand<TextContext>(textContext, tc => tc.BoldText());

        // reflection: typeof(TextContent).GetMethod("HighlightText").Invoke(textContext, null);

        var button = new Button(command1);
        button.Click();
    }
}
