namespace Dp.Creational.Builder;

internal static class Program
{
    public static void Main(string[] args)
    {
        var user = new UserBuilder()
            .WithFirstName("Shaun")
            .WithLastName("Chong")
            .Build();

        Console.WriteLine($"Hello, I am {user.FirstName} {user.LastName}");
    }
}
