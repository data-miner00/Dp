namespace Dp.Structural.Composite;

internal sealed class Directory : IFileSystemItem
{
    private readonly List<IFileSystemItem> fileSystemItems = [];
    private readonly int initialSize = 0;

    public Directory(string name)
    {
        this.Name = name;
    }

    public int Size
    {
        get
        {
            var treeSize = this.initialSize;

            foreach (var item in this.fileSystemItems)
            {
                treeSize += item.Size;
            }

            return treeSize;
        }
    }

    public string Name { get; }

    public void Add(IFileSystemItem fileSystemItem)
    {
        this.fileSystemItems.Add(fileSystemItem);
    }

    public void Remove(IFileSystemItem fileSystemItem)
    {
        this.fileSystemItems.Remove(fileSystemItem);
    }
}
