namespace Dp.Structural.Decorator;

internal static class Program
{
    public static async Task Main(string[] args)
    {
        var userRepository = new UserRepository();

        var loggedUserRepository = new LoggedUserRepository(userRepository);

        var counterUserRepository = new CounterUserRepository(loggedUserRepository);

        await counterUserRepository.AddAsync("shaun", default);
        await counterUserRepository.AddAsync("vicky", default);
        _ = await counterUserRepository.GetAllAsync(default);
        await counterUserRepository.AddAsync("lex", default);

        foreach (var log in loggedUserRepository.Logs)
        {
            Console.WriteLine(log);
        }
    }
}
