namespace Dp.Behavioral.Command.UnitTests;

public class AddUserCommandTests
{
    private readonly UserRepository repository = new();

    [Fact]
    public void CanExecute_UserNull_ReturnFalse()
    {
        var command = new AddUserCommand(null!, this.repository);

        Assert.False(command.CanExecute());
    }

    [Fact]
    public void CanExecute_UserBanned_ReturnFalse()
    {
        var user = new User
        {
            Name = "Shaun",
            Email = "doesn't matter i am banned",
        };

        var command = new AddUserCommand(user, this.repository);

        Assert.False(command.CanExecute());
    }

    [Fact]
    public void CanExecute_MeetRequirements_ReturnTrue()
    {
        var user = new User
        {
            Name = "Sharon",
            Email = "sharon@email.com",
        };

        var command = new AddUserCommand(user, this.repository);

        Assert.True(command.CanExecute());
    }

    [Fact]
    public void Execute_InsertUser_UserAdded()
    {
        var user = new User
        {
            Name = "Sharon",
            Email = "sharon@email.com",
        };

        var command = new AddUserCommand(user, this.repository);

        command.Execute();

        Assert.Contains(user, this.repository.Users);
    }

    [Fact]
    public void Undo_InsertAndUndo_UserRemoved()
    {
        var user = new User
        {
            Name = "Sharon",
            Email = "sharon@email.com",
        };

        var command = new AddUserCommand(user, this.repository);

        command.Execute();

        Assert.Contains(user, this.repository.Users);

        command.Undo();

        Assert.Empty(this.repository.Users);
    }

    [Fact]
    public void Undo_CommandNotExecuted_NothingHappened()
    {
        var user = new User
        {
            Name = "Sharon",
            Email = "sharon@email.com",
        };

        var command = new AddUserCommand(user, this.repository);

        // command.Execute();

        command.Undo();

        Assert.Empty(this.repository.Users);
    }
}
