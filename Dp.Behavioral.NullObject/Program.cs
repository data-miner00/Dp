namespace Dp.Behavioral.NullObject;

internal static class Program
{
    public static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();

        logger.Log("Message logged!");

        logger = new NullLogger();

        logger.Log("Message not logged :(");
    }
}
