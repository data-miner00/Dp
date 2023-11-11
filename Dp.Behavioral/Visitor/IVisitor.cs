using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp.Behavioral.Visitor
{
    public interface IVisitor
    {
        double Visit(Liquor item);
        double Visit(Tobacco item);
        double Visit(Necessity item);
    }
}
