namespace Dp.Creational.Singleton;

using System.Diagnostics.CodeAnalysis;

using Example1Logger = Dp.Creational.Singleton.Example1.Logger;
using Example2Logger = Dp.Creational.Singleton.Example2.Logger;

[ExcludeFromCodeCoverage]
internal static class Program
{
    public static void Main(string[] args)
    {
        int @case = 1;

        if (args.Length > 0 && !int.TryParse(args[0], out @case))
        {
            Console.Error.WriteLine("Error parsing the first argument to integer.");
            return;
        }

        switch (@case)
        {
            case 1:
                Example1();
                break;
            case 2:
                Example2();
                break;
        }
    }

    private static void Example1()
    {
        Example1Logger.Instance.LogInformation("Hello world");
    }

    private static void Example2()
    {
        Example2Logger.Instance.LogInformation("Hello world");
    }
}
