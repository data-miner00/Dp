namespace Dp.Behavioral.Memento.UnitTests;

using FluentAssertions;

public class TextEditorTests
{
    private readonly TextEditor textEditor = new();

    [Fact]
    public void Save_WithContent_ReturnExpectedState()
    {
        const string Content = "hjello, world!";
        var expectedMemento = new TextEditorState(this.textEditor, Content);

        this.textEditor.AppendText(Content);

        Assert.Equal(Content, this.textEditor.Content);

        var memento = this.textEditor.Save();

        // Further change
        this.textEditor.AppendText("blah");

        expectedMemento.Should().BeEquivalentTo(memento);
    }

    [Fact]
    public void Restore_WithMemento_RevertToPreviousState()
    {
        const string Content = "hjello, world!";

        this.textEditor.AppendText(Content);

        Assert.Equal(Content, this.textEditor.Content);

        var memento = this.textEditor.Save();

        // Further change
        this.textEditor.AppendText("blah");

        Assert.Equal(Content + "blah", this.textEditor.Content);

        memento.Restore();

        Assert.Equal(Content, this.textEditor.Content);
    }
}
