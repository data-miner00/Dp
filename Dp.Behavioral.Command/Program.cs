namespace Dp.Behavioral.Command;

internal static class Program
{
    public static void Main(string[] args)
    {
        var user = new User
        {
            Name = "Sharon",
            Email = "sharon@email.com",
        };

        var context = new CommandContext();

        var repository = new UserRepository();

        var addCommand = new AddUserCommand(user, repository);
        var addCommand2 = new AddUserCommand(new User { Name = "Ben", Email = "ben@email.com" }, repository);

        context.Invoke(addCommand);
        context.Invoke(addCommand2);

        var users = string.Join(',', repository.Users.Select(x => x.Name).ToArray());

        Console.WriteLine(users);
    }
}
