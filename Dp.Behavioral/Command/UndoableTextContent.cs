namespace Dp.Behavioral.Command;

public interface ITextCommand
{
    void Execute();
    void Undo();
}

public record HighlightConfig(int Colour, int Height);

public class HighlightText(string text, HighlightConfig config) : ITextCommand
{
    private readonly string text = text;
    private readonly HighlightConfig config = config;

    public void Execute()
    {
        // highlight and add to stack
    }

    public void Undo()
    {
        // called from stack popping
    }
}

public class BoldText(string text) : ITextCommand
{
    private readonly string text = text;

    public void Execute()
    {
        // bold and add to stack
    }

    public void Undo()
    {
        // called from stack popping
    }
}

public static class Usage2
{
    static Stack<ITextCommand> stack = new();

    public static void Main()
    {
        var text = "Hello";

        var hlCmd = new HighlightText(text, new HighlightConfig(1, 2));
        var boldCmd = new BoldText(text);

        stack.Push(hlCmd);
        stack.Push(boldCmd);

        // Undo
        stack.Pop().Undo();
    }
}
