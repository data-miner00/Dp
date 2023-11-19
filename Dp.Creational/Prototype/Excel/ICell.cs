using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp.Creational.Prototype.Excel
{
    internal interface ICell
    {
        string Render { get; }
        ICell Clone();
    }
}
