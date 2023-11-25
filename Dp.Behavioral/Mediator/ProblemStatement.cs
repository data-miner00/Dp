namespace Dp.Behavioral.Mediator;

public class LogicA
{
    LogicB b;

    public void Do()
    {
        b.Do();
    }
}

public class LogicB
{
    public void Do()
    {

    }
}