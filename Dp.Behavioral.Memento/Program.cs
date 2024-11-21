namespace Dp.Behavioral.Memento;

internal static class Program
{
    public static void Main(string[] args)
    {
        var textEditor = new TextEditor();

        Console.WriteLine("-- Initial --");
        textEditor.AppendText("hello world");

        Console.WriteLine(textEditor.Content);

        Console.WriteLine("-- Saved --");
        var memento = textEditor.Save();

        Console.WriteLine("-- Further --");
        textEditor.AppendText("hello world");
        Console.WriteLine(textEditor.Content);

        memento.Restore();

        Console.WriteLine("-- Restored --");
        Console.WriteLine(textEditor.Content);
    }
}
