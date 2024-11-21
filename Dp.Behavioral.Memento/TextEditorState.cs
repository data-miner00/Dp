namespace Dp.Behavioral.Memento;

internal sealed class TextEditorState
{
    private readonly TextEditor editor;
    private readonly string content;

    public TextEditorState(TextEditor editor, string content)
    {
        this.editor = editor;
        this.content = content;
    }

    public TextEditor Editor => this.editor;

    public string Content => this.content;

    public void Restore()
    {
        this.editor.SetContent(this.content);
    }
}
