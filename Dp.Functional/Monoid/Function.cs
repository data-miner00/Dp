namespace Dp.Functional.Monoid;

internal struct Function<T>
{
    public Func<T, T> run;

    public Function(Func<T, T> run) => this.run = run;

    public Function<T> Then(Function<T> next)
    {
        var runCopy = run;
        return new(x => runCopy(next.run(x)));
    }

    public static Function<T> operator +(Function<T> left, Function<T> right)
    {
        return new(x => left.run(right.run(x)));
    }
}

internal static class FunctionExtensions
{
    public static Function<T> Then<T>(this Function<T> @this, Function<T> next)
    {
        return new(x => @this.run(next.run(x)));
    }
}

public static class Program
{
    static void Main()
    {
        int Add10(int a) => a + 10;

        Function<int> add5 = new(a => a + 5);
        Function<int> add10 = new(Add10);

        var add15 = add5 + add10;

        Function<int> IDENTITY = new(a => a);

        // Rules
        // - Associativity
        // - Identity
        _ = ((IDENTITY + add5).run(5) == add5.run(5));
        _ = ((add5 + IDENTITY).run(5) == add5.run(5));
    }
}
