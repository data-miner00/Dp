namespace Dp.Behavioral.ChainOfResponsibility;

using System;

internal sealed class InitialHandler : IHandler
{
    private readonly IHandler next;

    public InitialHandler(IHandler next)
    {
        this.next = next;
    }

    public void Handle(Request request)
    {
        Console.WriteLine("Id is: " + request.Id);
        this.next.Handle(request);
    }
}
