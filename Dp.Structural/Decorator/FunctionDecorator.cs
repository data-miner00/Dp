namespace Dp.Structural.Decorator;

public static class FunctionDecorator
{
    public static void Main()
    {
        Func<int, int, int> add = PrintResult(Add);
        Func<int, int, int> addPrintSquare = Square(add);
        Func<int, int, int> addSquarePrint = PrintResult(Square(Add));

        Console.WriteLine(add(5, 5));
        Console.WriteLine(addPrintSquare(5, 5));
        Console.WriteLine(addSquarePrint(5, 5));
    }

    public static int Add(int a, int b) => a + b;

    public static Func<int, int, int> PrintResult(Func<int, int, int> fn)
    {
        return (int a, int b) =>
        {
            int result = fn(a, b);

            Console.WriteLine("Processed");

            return result;
        };
    }

    public static Func<int, int, int> Square(Func<int, int, int> fn)
    {
        return (int a, int b) =>
        {
            int result = fn(a, b);
            return result * result;
        };
    }
}