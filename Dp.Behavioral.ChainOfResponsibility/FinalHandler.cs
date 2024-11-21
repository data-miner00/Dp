namespace Dp.Behavioral.ChainOfResponsibility;

using System;

internal sealed class FinalHandler : IHandler
{
    // Should implement the next as well for us to swap around the sequence but its fine for now
    public void Handle(Request request)
    {
        Console.WriteLine("Age is: " + request.Age);
    }
}
