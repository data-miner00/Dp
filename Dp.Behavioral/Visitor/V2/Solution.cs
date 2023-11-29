namespace Dp.Behavioral.Visitor.V2;

internal interface IRepository
{
    void Visit(IOperation operation);
}

/// <summary>
/// Need to be wary of the number of operations. It should be
/// </summary>
internal interface IOperation
{
    void VisitPostgres(PostgreSQL2 pg);
    void VisitMongoDb(MongoDB2 db);
    void VisitRedis(Redis2 rd);
}

internal class MongoDB2 : IRepository
{
    public void Visit(IOperation operation)
    {
        operation.VisitMongoDb(this);
    }
}

internal class PostgreSQL2 : IRepository
{
    public void Visit(IOperation operation)
    {
        operation.VisitPostgres(this);
    }
}

internal class Redis2 : IRepository
{
    public void Visit(IOperation operation)
    {
        operation.VisitRedis(this);
    }
}

internal abstract class Get<T> : IOperation
{
    public T Result { get; set; }

    public abstract void VisitMongoDb(MongoDB2 db);

    public abstract void VisitPostgres(PostgreSQL2 pg);

    public abstract void VisitRedis(Redis2 rd);
}

internal class GetInt : Get<int>
{
    public override void VisitMongoDb(MongoDB2 db)
    {
        this.Result = 1;
    }

    public override void VisitPostgres(PostgreSQL2 pg)
    {
        this.Result = 2;
    }

    public override void VisitRedis(Redis2 rd)
    {
        this.Result = 3;
    }
}
