namespace Dp.Functional.Monoid;

internal static class Examples
{
    /// <summary>
    /// Identity is something applied to the original data but still get the original data back.
    /// E.g 1 + 0 = 1; 0 is the identity.
    /// Real world use case:
    /// - Task + Task + Task
    /// - CloudFunction + CloudFunction + CloudFunction
    /// - VM + VM + VM
    /// </summary>
    static void Main()
    {
        int a = 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1 + 1;      // + is monoid
        bool b = true || true || true || false || true;     // || is monoid
        bool c = true && true && false;                     // && is monoid

        var add = new Add((a, b) => a + b);

        var total = add(1, 2);
    }

    public delegate int Add(int a, int b);
}
