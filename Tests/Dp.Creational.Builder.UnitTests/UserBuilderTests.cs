namespace Dp.Creational.Builder.UnitTests;

using Dp.Creational.Builder;

public class UserBuilderTests
{
    [Fact]
    public void Build_WithUnsetField_ReturnsUserWithDefaultValue()
    {
        var user = new UserBuilder().Build();

        Assert.NotNull(user);
        Assert.Equal(string.Empty, user.FirstName);
        Assert.Equal(string.Empty, user.LastName);
        Assert.Equal(string.Empty, user.Email);
        Assert.Equal(string.Empty, user.PhoneNumber);
        Assert.Equal(string.Empty, user.Country);
        Assert.Equal(string.Empty, user.Username);
        Assert.Equal(string.Empty, user.PasswordHash);
        Assert.False(user.IsEmailVerified);
        Assert.False(user.IsPhoneVerified);
        Assert.Equal(DateTime.MinValue, user.DateOfBirth);
        Assert.Equal("en", user.PreferredLanguage);
        Assert.Empty(user.Permissions);
        Assert.Empty(user.Metadata);
    }

    [Fact]
    public void Build_WithSetField_ReturnsUserWithSpecifiedValue()
    {
        var user = new UserBuilder()
            .WithFirstName("Shaun")
            .WithLastName("Chong")
            .WithEmail("shaun.chong@tuta.io")
            .WithPhoneNumber("123 456 5323")
            .WithCountry("Malaysia")
            .WithUsername("mumk")
            .WithPasswordHash("0xF00D")
            .WithIsEmailVerified(true)
            .AddPermissions("repo", "repo.read", "repo.write", "profile")
            .AddMetadata("strange", "yes")
            .AddMetadata("going", "yes")
            .Build();

        Assert.NotNull(user);
        Assert.Equal("Shaun", user.FirstName);
        Assert.Equal("Chong", user.LastName);
        Assert.Equal("shaun.chong@tuta.io", user.Email);
        Assert.Equal("123 456 5323", user.PhoneNumber);
        Assert.Equal("Malaysia", user.Country);
        Assert.Equal("mumk", user.Username);
        Assert.Equal("0xF00D", user.PasswordHash);
        Assert.True(user.IsEmailVerified);
        Assert.False(user.IsPhoneVerified);
        Assert.Equal(DateTime.MinValue, user.DateOfBirth);
        Assert.Equal("en", user.PreferredLanguage);
        Assert.Equal(["repo", "repo.read", "repo.write", "profile"], user.Permissions);
        Assert.Equal(
            new Dictionary<string, string>
            {
                { "strange", "yes" },
                { "going", "yes" },
            },
            user.Metadata);
    }
}
