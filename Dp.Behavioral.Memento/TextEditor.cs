namespace Dp.Behavioral.Memento;

using System.Text;

internal sealed class TextEditor
{
    private StringBuilder textBuffer = new();

    public string Content => this.textBuffer.ToString();

    public void AppendText(string text)
    {
        this.textBuffer.Append(text);
    }

    public TextEditorState Save()
    {
        return new TextEditorState(this, this.textBuffer.ToString());
    }

    public void SetContent(string content)
    {
        this.textBuffer.Clear();
        this.textBuffer.Append(content);
    }
}
