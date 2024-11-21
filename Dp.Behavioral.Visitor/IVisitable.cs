namespace Dp.Behavioral.Visitor;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal interface IVisitable
{
    void Accept(IVisitor visitor);
}
