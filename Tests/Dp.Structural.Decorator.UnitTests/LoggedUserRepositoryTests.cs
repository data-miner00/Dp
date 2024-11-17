namespace Dp.Structural.Decorator.UnitTests;

using FluentAssertions;
using System.Collections.Generic;
using System.Threading.Tasks;

public sealed class LoggedUserRepositoryTests
{
    private readonly LoggedUserRepository repository;

    public LoggedUserRepositoryTests()
    {
        // Better to use Moq instead of passing real impl.
        var baseRepository = new UserRepository();

        this.repository = new LoggedUserRepository(baseRepository);
    }

    [Fact]
    public async Task AddAsync_WithTwoUsers_AddUsersAndLogs()
    {
        const string FirstUser = "shaun";
        const string SecondUser = "vicky";

        List<string> expectedUsers = [FirstUser, SecondUser];
        List<string> expectedStrippedLogs =
        [
            "Add called with username 'shaun'.",
            "Add called with username 'vicky'.",
            "GetAll called.",
        ];

        await this.repository.AddAsync(FirstUser, default);
        await this.repository.AddAsync(SecondUser, default);

        var actual = await this.repository.GetAllAsync(default);

        actual.Should().BeEquivalentTo(expectedUsers);

        var strippedLogs = this.repository.Logs.Select(x =>
        {
            var split = x.Split(": ");
            return split[1];
        }).ToList();

        strippedLogs.Should().BeEquivalentTo(expectedStrippedLogs);
    }

    [Fact]
    public async Task GetAllAsync_CalledTwice_LogsTwice()
    {
        _ = await this.repository.GetAllAsync(default);
        _ = await this.repository.GetAllAsync(default);

        List<string> expectedStrippedLogs =
        [
            "GetAll called.",
            "GetAll called.",
        ];

        var strippedLogs = this.repository.Logs.Select(x =>
        {
            var split = x.Split(": ");
            return split[1];
        }).ToList();

        strippedLogs.Should().BeEquivalentTo(expectedStrippedLogs);
    }
}
