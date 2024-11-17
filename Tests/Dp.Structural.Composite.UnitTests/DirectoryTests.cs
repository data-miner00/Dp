namespace Dp.Structural.Composite.UnitTests;

using Composite = Dp.Structural.Composite;

public sealed class DirectoryTests
{
    [Fact]
    public void Directory_AddFilesAndFolders_CalculateSizeCorrectly()
    {
        var root = new Composite.Directory("root");
        var txtFile = new Composite.File("hello.txt", 30);

        var subfolder1 = new Composite.Directory("subfolder1");
        var subfolder2 = new Composite.Directory("subfolder2");

        var pyFile = new Composite.File("main.py", 564);
        var csFile = new Composite.File("Program.cs", 60);
        var hsFile = new Composite.File("Main.hs", 3000);

        subfolder1.Add(pyFile);
        subfolder2.Add(csFile);
        subfolder2.Add(hsFile);

        root.Add(txtFile);
        root.Add(subfolder1);
        root.Add(subfolder2);

        Assert.Equal(3654, root.Size);
    }

    [Fact]
    public void Directory_RemoveExistingFile_SizeEmpty()
    {
        var root = new Composite.Directory("root");
        var txtFile = new Composite.File("hello.txt", 30);

        root.Add(txtFile);
        Assert.Equal(30, root.Size);

        root.Remove(txtFile);
        Assert.Equal(0, root.Size);
    }
}
