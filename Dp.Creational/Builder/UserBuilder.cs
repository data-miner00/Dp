namespace Dp.Creational.Builder;

public class UserBuilder : IObjectBuilder<User>
{
    private string name = "Jane";
    private string email = "jane@email.com";
    private string password = "password123";
    private string company = "dhl";
    private int age = 24;
    private DateTime created = DateTime.Now;
    private DateTime updated = DateTime.Now;

    public UserBuilder WithName(string name)
    {
        this.name = name;
        return this;
    }

    public UserBuilder WithEmail(string email)
    {
        this.email = email;
        return this;
    }

    public UserBuilder WithPassword(string password)
    {
        this.password = password;
        return this;
    }

    public UserBuilder WithCompant(string company)
    {
        this.company = company;
        return this;
    }

    public UserBuilder WithAge(int age)
    {
        this.age = age;
        return this;
    }

    public UserBuilder WithCreated(DateTime created)
    {
        this.created = created;
        return this;
    }

    public UserBuilder WithUpdated(DateTime updated)
    {
        this.updated = updated;
        return this;
    }

    public User Build()
    {
        return new User
        {
            Name = name,
            Email = email,
            Password = password,
            Company = company,
            Age = age,
            Created = created,
            Updated = updated,
        };
    }
}
