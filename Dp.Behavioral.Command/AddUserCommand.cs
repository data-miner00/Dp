namespace Dp.Behavioral.Command;

using System;

internal sealed class AddUserCommand : ICommand
{
    private const string BannedUser = "Shaun";
    private readonly User user;
    private readonly UserRepository repository;
    private bool isExecuted = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="AddUserCommand"/> class.
    /// </summary>
    /// <param name="user">The user to be added.</param>
    /// <param name="repository">The user repository.</param>
    public AddUserCommand(User user, UserRepository repository)
    {
        this.user = user;
        this.repository = repository;
    }

    /// <inheritdoc/>
    public bool CanExecute()
    {
        if (this.user is null || this.user.Name.Equals(BannedUser, StringComparison.InvariantCulture))
        {
            return false;
        }

        return true;
    }

    /// <inheritdoc/>
    public void Execute()
    {
        this.repository.Add(this.user);
        this.isExecuted = true;
    }

    /// <inheritdoc/>
    public void Undo()
    {
        if (!this.isExecuted)
        {
            return;
        }

        this.repository.Remove(this.user);
    }
}
