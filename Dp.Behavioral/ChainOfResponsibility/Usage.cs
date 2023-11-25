namespace Dp.Behavioral.ChainOfResponsibility;

internal static class Usage
{
    static void Main()
    {
        var ide = new IntegratedDevEnv(null);
        var editor = new CodeEditor(ide);
        var codeSelection = new CodeSelection(editor);

        codeSelection.HandleKey("Ctrl+F");
        codeSelection.HandleKey("Alt+F4");
    }
}
