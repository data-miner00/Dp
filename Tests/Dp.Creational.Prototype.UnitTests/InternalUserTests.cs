namespace Dp.Creational.Prototype.UnitTests;

using Dp.Creational.Prototype;
using FluentAssertions;

public sealed class InternalUserTests
{
    [Fact]
    public void Clone_WithExistingStates_MatchesCopy()
    {
        var internalUser = new InternalUser
        {
            FirstName = "Shaun",
            LastName = "Chong",
            Department = "Human Resource",
        };

        var copy = (InternalUser)internalUser.Clone();

        // Asserting reference
        Assert.NotEqual(internalUser, copy);
        Assert.NotSame(internalUser, copy);

        // Asserting deep equivalence
        copy.Should().BeEquivalentTo(internalUser);
    }

    [Fact]
    public void DeepClone_WithExistingStates_MatchesCopy()
    {
        var internalUser = new InternalUser
        {
            FirstName = "Shaun",
            LastName = "Chong",
            Department = "Human Resource",
        };

        var copy = (InternalUser)internalUser.DeepClone();

        // Asserting reference
        Assert.NotEqual(internalUser, copy);
        Assert.NotSame(internalUser, copy);

        // Asserting deep equivalence
        copy.Should().BeEquivalentTo(internalUser);
    }
}
