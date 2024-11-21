namespace Dp.Behavioral.ChainOfResponsibility;

using System;

internal sealed class MiddleHandler : IHandler
{
    private readonly IHandler next;

    public MiddleHandler(IHandler next)
    {
        this.next = next;
    }

    public void Handle(Request request)
    {
        Console.WriteLine("Name: " + request.Name);
        this.next.Handle(request);
    }
}
