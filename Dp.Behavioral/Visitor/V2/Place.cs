namespace Dp.Behavioral.Visitor.V2;

internal abstract class Place
{
    public abstract void Visit(Visitor visitor);
}

internal abstract class Visitor
{
    public abstract void VisitPark(Park park);
    public abstract void VisitHome(Home home);
}

internal class Park : Place
{
    public override void Visit(Visitor visitor)
    {
        visitor.VisitPark(this);
    }
}

internal class Home : Place
{
    public override void Visit(Visitor visitor)
    {
        visitor.VisitHome(this);
    }
}

internal class Dude : Visitor
{
    public override void VisitHome(Home home)
    {
        Console.WriteLine("Play video games");
    }

    public override void VisitPark(Park park)
    {
        Console.WriteLine("Smoke weed");
    }
}

internal class Robber : Visitor
{
    public override void VisitHome(Home home)
    {
        Console.WriteLine("Steal some socks");
    }

    public override void VisitPark(Park park)
    {
        Console.WriteLine("Steal a dog");
    }
}
