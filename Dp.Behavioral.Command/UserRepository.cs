namespace Dp.Behavioral.Command;

using System.Collections.Generic;

internal sealed class UserRepository
{
    private readonly List<User> users = [];

    public List<User> Users => this.users;

    public void Add(User user)
    {
        this.users.Add(user);
    }

    public void Remove(User user)
    {
        var success = this.users.Remove(user);
    }
}
