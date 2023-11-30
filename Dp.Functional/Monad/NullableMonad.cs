namespace Dp.Functional.Monad;

internal class NullableMonad
{
    static void Main()
    {
        string? foo = null;

        if (foo != null)
        {
            foo = foo.Trim();
        }

        if (foo != null)
        {
            foo = foo.Substring(0, 5);
        }

        int leastLength = foo == null ? 0 : foo.Length;

        int leastLength2 = foo?.Trim()?.Substring(0, 5)?.Length ?? 0;

        var a = IfNotNull(5, i => i * i);
        var b = IfNotNull(a, i => i + 1);
    }

    static R? IfNotNull<T, R>(T v, Func<T, R> f) => v == null ? default : f(v);
}
