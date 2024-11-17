namespace Dp.Structural.Composite;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal sealed class File : IFileSystemItem
{
    public File(string name, int size)
    {
        this.Name = name;
        this.Size = size;
    }

    public int Size { get; }

    public string Name { get; }
}
