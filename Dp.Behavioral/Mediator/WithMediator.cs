namespace Dp.Behavioral.Mediator;

internal class LogicA2
{
    DoctorRoom m;

    public void Do()
    {
        m.Interaction("b");
    }
}

/// <summary>
/// The context in which the interactions is happening.
/// </summary>
public class DoctorRoom : IMediator
{
    LogicB2 b;

    public void Interaction() { }

    public void Interaction(string action)
    {
        if (action == "b")
        {
            b.Do();
        }
    }
}

internal class LogicB2
{
    public void Do()
    {
        Console.WriteLine("Doing B2 logic");
    }
}
