using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp.Creational.Prototype.Excel
{
    internal class CellFactory
    {
        public static ICell Create(string content)
        {
            if (DateTime.TryParse(content, out var date))
            {
                return new DateTimeCell
                {
                    Format = "dd/MM/yyyy",
                    DateTime = date,
                };
            }

            if (int.TryParse(content, out var i))
            {
                return new NumberCell
                {
                    Number = i,
                };
            }

            return new TextCell { Content = content };
        }
    }
}
