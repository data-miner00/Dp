using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp.Creational.Prototype.Excel
{
    internal class Usage
    {
        public static void Main()
        {
            var grid = new List<ICell>
            {
                CellFactory.Create("Hello World"),
                CellFactory.Create("31"),
                CellFactory.Create("22/02/2003"),
            };

            var clonedBlock3 = (DateTimeCell)grid[2].Clone();
            clonedBlock3.Format = "MM/dd/yyyy";
            grid.Add(clonedBlock3);

            var clonedBlock4 = (DateTimeCell)grid[3].Clone();
            clonedBlock4.DateTime = DateTime.UtcNow;
            grid.Add(clonedBlock4);
        }
    }
}
