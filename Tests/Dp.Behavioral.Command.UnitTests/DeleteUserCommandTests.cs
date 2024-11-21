namespace Dp.Behavioral.Command.UnitTests;

public sealed class DeleteUserCommandTests
{
    private readonly UserRepository repository;
    private readonly User user = new User
    {
        Name = "Sharon",
        Email = "sharon@email.com",
    };

    public DeleteUserCommandTests()
    {
        this.repository = new UserRepository();

        // Adds 1 user
        var addUserCommand = new AddUserCommand(user!, this.repository);
        if (addUserCommand.CanExecute())
        {
            addUserCommand.Execute();
        }
    }

    [Fact]
    public void CanExecute_UserNull_ReturnFalse()
    {
        var command = new RemoveUserCommand(null!, this.repository);

        Assert.False(command.CanExecute());
    }

    [Fact]
    public void CanExecute_UserNotNull_ReturnTrue()
    {
        var command = new RemoveUserCommand(this.user, this.repository);

        Assert.True(command.CanExecute());
    }

    [Fact]
    public void Execute_UserValid_UserRemoved()
    {
        var command = new RemoveUserCommand(this.user, this.repository);

        Assert.Contains(this.user, this.repository.Users);

        command.Execute();

        Assert.DoesNotContain(this.user, this.repository.Users);
        Assert.Empty(this.repository.Users);
    }

    [Fact]
    public void Undo_UserRemoved_UserAddedBack()
    {
        var command = new RemoveUserCommand(this.user, this.repository);

        Assert.Contains(this.user, this.repository.Users);

        command.Execute();

        Assert.DoesNotContain(this.user, this.repository.Users);
        Assert.Empty(this.repository.Users);

        command.Undo();

        Assert.Contains(this.user, this.repository.Users);
        Assert.Single(this.repository.Users);
    }
}
