namespace Dp.Creational.Builder;

using System;
using System.Collections.Generic;

internal sealed class User
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Country { get; set; }

    public string Username { get; set; }

    public string PasswordHash { get; set; }

    public bool IsEmailVerified { get; set; }

    public bool IsPhoneVerified { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string PreferredLanguage { get; set; } = "en";

    public List<string> Permissions { get; set; } = [];

    public Dictionary<string, string> Metadata { get; set; } = [];
}
