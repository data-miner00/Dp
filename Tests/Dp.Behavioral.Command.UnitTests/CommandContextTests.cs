namespace Dp.Behavioral.Command.UnitTests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal sealed class CommandContextTests
{
    private readonly UserRepository repository = new();
    private readonly CommandContext context = new();
    private readonly User user = new User
    {
        Name = "Sharon",
        Email = "sharon@email.com",
    };

    [Fact]
    public void Invoke_MetRequirements_AddedToStack()
    {
        var command = new AddUserCommand(this.user, this.repository);

        this.context.Invoke(command);

        Assert.Single(this.context.ExecutedCommands);
        Assert.Contains(command, this.context.ExecutedCommands);
    }

    [Fact]
    public void Invoke_NotMetRequirements_NotAddedToStack()
    {
        var bannedUser = new User
        {
            Name = "Shaun",
            Email = "asdfj",
        };

        var command = new AddUserCommand(bannedUser, this.repository);

        this.context.Invoke(command);

        Assert.Empty(this.context.ExecutedCommands);
        Assert.DoesNotContain(command, this.context.ExecutedCommands);
    }

    [Fact]
    public void Undo_ExecutedTwoCommands_UndoTheLastCommand()
    {
        var user1 = new User { Name = "Nary", Email = "nary@mail.com" };
        var user2 = new User { Name = "Mike", Email = "mike@mail.com" };
        var command = new AddUserCommand(user1, this.repository);
        var command2 = new AddUserCommand(user2, this.repository);

        this.context.Invoke(command);
        this.context.Invoke(command2);

        Assert.Contains(user1, this.repository.Users);
        Assert.Contains(user2, this.repository.Users);
        Assert.Equal(2, this.context.ExecutedCommands.Count);
        Assert.Equal(2, this.repository.Users.Count);

        this.context.Undo();

        Assert.Contains(user1, this.repository.Users);
        Assert.DoesNotContain(user2, this.repository.Users);
        Assert.Single(this.context.ExecutedCommands);
        Assert.Single(this.repository.Users);
    }
}
