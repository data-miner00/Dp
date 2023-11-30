namespace Dp.Functional.Monad;

public class Option<T>
{
    protected Option()
    {
    }

    public Option(T value)
    {
        this.Value = value;
    }

    public T Value { get; set; }
    public virtual bool HasValue => this.Value != null;
    public static None<T> None = new();
}

public class None<T> : Option<T>
{
    public override bool HasValue => false;
}
