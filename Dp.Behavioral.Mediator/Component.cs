namespace Dp.Behavioral.Mediator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal abstract class Component
{
    protected readonly ILogMediator mediator;

    protected Component(ILogMediator mediator)
    {
        this.mediator = mediator;
    }

    public abstract void Click();
}
