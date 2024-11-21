namespace Dp.Behavioral.Observer;

internal static class Program
{
    public static void Main(string[] args)
    {
        var publisher = new Publisher("Initial");

        publisher.Subscribe((newContent) =>
        {
            Console.WriteLine("The new content is: " + newContent);
        });

        publisher.Subscribe((newContent) =>
        {
            Console.WriteLine("Woohoo, new content! " + newContent);
        });

        publisher.Content = "Let's goo";
        publisher.Content = "Woohooo";
    }
}
