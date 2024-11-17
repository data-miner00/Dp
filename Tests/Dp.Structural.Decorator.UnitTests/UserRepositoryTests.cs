namespace Dp.Structural.Decorator.UnitTests;

using FluentAssertions;

public sealed class UserRepositoryTests
{
    [Fact]
    public async Task AddAsync_AddTwoUsers_ExpectTwoUsersInRepository()
    {
        const string FirstUser = "shaun";
        const string SecondUser = "vicky";

        List<string> expectedUsers = [FirstUser, SecondUser];

        var repository = new UserRepository();

        await repository.AddAsync(FirstUser, default);
        await repository.AddAsync(SecondUser, default);

        var actual = await repository.GetAllAsync(default);

        actual.Should().BeEquivalentTo(expectedUsers);
    }
    // [17/11/2024 3:09:58 PM]: Add called with username 'shaun'.
}
