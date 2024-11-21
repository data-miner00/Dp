namespace Dp.Behavioral.ChainOfResponsibility;

internal static class Program
{
    public static void Main(string[] args)
    {
        var handler = new InitialHandler(new MiddleHandler(new FinalHandler()));

        var request = new Request
        {
            Id = "abc",
            Name = "My Name",
            Age = 3,
        };

        handler.Handle(request);
    }
}
