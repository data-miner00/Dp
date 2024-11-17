namespace Dp.Structural.Decorator.UnitTests;

using FluentAssertions;
using System.Collections.Generic;
using System.Threading.Tasks;

public sealed class CounterUserRepositoryTests
{
    private readonly CounterUserRepository repository;

    public CounterUserRepositoryTests()
    {
        // Better to use Moq instead of passing real impl.
        var baseRepository = new UserRepository();

        this.repository = new CounterUserRepository(baseRepository);
    }

    [Fact]
    public async Task AddAsync_WithTwoUsers_AddUsersAndCounts()
    {
        const string FirstUser = "shaun";
        const string SecondUser = "vicky";

        List<string> expectedUsers = [FirstUser, SecondUser];
        const int ExpectedCount = 2;

        await this.repository.AddAsync(FirstUser, default);
        await this.repository.AddAsync(SecondUser, default);

        var actual = await this.repository.GetAllAsync(default);

        actual.Should().BeEquivalentTo(expectedUsers);

        var actualCount = this.repository.AddCounter;

        actualCount.Should().Be(ExpectedCount);
    }

    [Fact]
    public async Task GetAllAsync_CalledTwice_CountTwice()
    {
        _ = await this.repository.GetAllAsync(default);
        _ = await this.repository.GetAllAsync(default);

        const int ExpectedCount = 2;

        var actualCount = this.repository.GetAllCounter;

        actualCount.Should().Be(ExpectedCount);
    }
}
