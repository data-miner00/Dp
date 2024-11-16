namespace Dp.Creational.Builder;

using System;
using System.Collections.Generic;

internal sealed class UserBuilder
{
    private Guid id = Guid.NewGuid();

    private string firstName = string.Empty;

    private string lastName = string.Empty;

    private string email = string.Empty;

    private string phoneNumber = string.Empty;

    private string country = string.Empty;

    private string username = string.Empty;

    private string passwordHash = string.Empty;

    private bool isEmailVerified;

    private bool isPhoneVerified;

    private DateTime dateOfBirth = DateTime.MinValue;

    private string preferredLanguage = "en";

    private List<string> permissions = [];

    private Dictionary<string, string> metadata = [];

    public UserBuilder WithId(Guid value)
    {
        this.id = value;
        return this;
    }

    public UserBuilder WithFirstName(string value)
    {
        this.firstName = value;
        return this;
    }

    public UserBuilder WithLastName(string value)
    {
        this.lastName = value;
        return this;
    }

    public UserBuilder WithEmail(string value)
    {
        this.email = value;
        return this;
    }

    public UserBuilder WithPhoneNumber(string value)
    {
        this.phoneNumber = value;
        return this;
    }

    public UserBuilder WithCountry(string value)
    {
        this.country = value;
        return this;
    }

    public UserBuilder WithUsername(string value)
    {
        this.username = value;
        return this;
    }

    public UserBuilder WithPasswordHash(string value)
    {
        this.passwordHash = value;
        return this;
    }

    public UserBuilder WithIsEmailVerified(bool value)
    {
        this.isEmailVerified = value;
        return this;
    }

    public UserBuilder WithIsPhoneVerified(bool value)
    {
        this.isPhoneVerified = value;
        return this;
    }

    public UserBuilder WithDateOfBirth(DateTime value)
    {
        this.dateOfBirth = value;
        return this;
    }

    public UserBuilder WithPreferredLanguage(string value)
    {
        this.preferredLanguage = value;
        return this;
    }

    public UserBuilder WithPermissions(List<string> value)
    {
        this.permissions = value;
        return this;
    }

    public UserBuilder AddPermissions(params string[] permissions)
    {
        this.permissions.AddRange(permissions);
        return this;
    }

    public UserBuilder WithMetadata(Dictionary<string, string> value)
    {
        this.metadata = value;
        return this;
    }

    public UserBuilder AddMetadata(string key, string value)
    {
        this.metadata.Add(key, value);
        return this;
    }

    public User Build()
    {
        return new User
        {
            Id = this.id,
            FirstName = this.firstName,
            LastName = this.lastName,
            Email = this.email,
            PhoneNumber = this.phoneNumber,
            Country = this.country,
            Username = this.username,
            PasswordHash = this.passwordHash,
            IsEmailVerified = this.isEmailVerified,
            IsPhoneVerified = this.isPhoneVerified,
            DateOfBirth = this.dateOfBirth,
            PreferredLanguage = this.preferredLanguage,
            Permissions = this.permissions,
            Metadata = this.metadata,
        };
    }
}
