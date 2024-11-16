namespace Dp.Creational.Prototype.UnitTests;

using Dp.Creational.Prototype;
using FluentAssertions;

public sealed class ExternalUserTests
{
    [Fact]
    public void Clone_WithExistingStates_MatchesCopy()
    {
        var externalUser = new ExternalUser
        {
            FirstName = "Shaun",
            LastName = "Chong",
            Company = "Amazon",
        };

        var copy = externalUser.Clone();

        // Asserting reference
        Assert.NotEqual(externalUser, copy);
        Assert.NotSame(externalUser, copy);

        // Asserting deep equivalence
        copy.Should().BeEquivalentTo(externalUser);
    }

    [Fact]
    public void DeepClone_WithExistingStates_MatchesCopy()
    {
        var externalUser = new ExternalUser
        {
            FirstName = "Shaun",
            LastName = "Chong",
            Company = "Amazon",
        };

        var copy = externalUser.DeepClone();

        // Asserting reference
        Assert.NotEqual(externalUser, copy);
        Assert.NotSame(externalUser, copy);

        // Asserting deep equivalence
        copy.Should().BeEquivalentTo(externalUser);
    }
}
