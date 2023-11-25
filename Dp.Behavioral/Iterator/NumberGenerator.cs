namespace Dp.Behavioral.Iterator
{
    /// <summary>
    /// Known as cursor or generator. IEnumerable in C#.
    /// </summary>
    internal static class NumberGenerator
    {
        public static IEnumerable<int> Generate(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return i;
            }
        }
    }
}
