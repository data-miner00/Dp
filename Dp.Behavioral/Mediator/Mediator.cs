namespace Dp.Behavioral.Mediator;

internal interface IMediator
{
    void Interaction();
}

/// <summary>
/// Central context of orchestrating interactions.
/// </summary>
internal class Mediator : IMediator
{
    public Piece piece;
    public Part part;
    public Thing thing;

    public void Interaction()
    {
        Console.WriteLine("Mediating interaction");
    }
}

internal class Piece(IMediator mediator)
{
    IMediator mediator = mediator;

    public void Invoke()
    {
        mediator.Interaction();
    }
}

internal class Part(IMediator mediator)
{
    IMediator Mediator = mediator;
}

internal class Thing(IMediator mediator)
{
    IMediator Mediator = mediator;
}
