namespace Dp.Functional.Monad;

public static class Extensions
{
    public static Option<T> From<T>(this T value) => new(value);

    public static Option<C> Bind<B, C>(this B b, Func<B, Option<C>> f) => b.From().Bind(f);

    public static Option<C> Bind<B, C>(this Option<B> b, Func<B, Option<C>> f) =>
        b.HasValue ? f(b.Value) : Option<C>.None;
}

public static class Usage
{
    static void Main()
    {
        string? foo = null;

        var result = foo.From()
            .Bind(x => x.Trim().From())
            .Bind(x => x[..5].From())
            .Bind(x => x.Length.From());
    }

    static void Rules()
    {
        string? str = "String";

        // left identity: monad construction doesn't change function behaviour
        _ = str.Bind(x => x.Trim().From()).Value == str.Trim();

        // right identity: re-wrapping doesn't change the value
        _ = str.From().Bind(str => new Option<string>(str)).Value == str;

        // associativity (doesn't matter what sequence the binding the result will be the same
        _ = str.Bind(str => str.Trim().From()).Bind(str => str.Substring(0, 5).From()).Value ==
            str.Bind(str => str.Substring(0, 5).From()).Bind(str => str.Trim().From()).Value;
    }
}
