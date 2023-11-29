namespace Dp.Behavioral.Visitor.V2;

internal class Repository
{
    public virtual int Get()
    {
        return 0;
    }

    public virtual int[] List()
    {
        return [];
    }

    public virtual void Write(int id)
    {
        Console.WriteLine("Written");
    }

    public virtual void Update(int id)
    {
        Console.WriteLine("Updated");
    }
}

internal class PostgreSQL : Repository;

internal class MongoDB : Repository;

internal class Redis : Repository;
