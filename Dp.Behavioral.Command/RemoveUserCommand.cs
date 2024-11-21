namespace Dp.Behavioral.Command;

internal sealed class RemoveUserCommand : ICommand
{
    private readonly User user;
    private readonly UserRepository repository;
    private bool isExecuted = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="RemoveUserCommand"/> class.
    /// </summary>
    /// <param name="user">The user to be removed.</param>
    /// <param name="repository">The user respository.</param>
    public RemoveUserCommand(User user, UserRepository repository)
    {
        this.user = user;
        this.repository = repository;
    }

    /// <inheritdoc/>
    public bool CanExecute()
    {
        if (this.user == null)
        {
            return false;
        }

        if (this.user.Email.Equals(string.Empty))
        {
            return false;
        }

        return true;
    }

    /// <inheritdoc/>
    public void Execute()
    {
        this.repository.Remove(this.user);
        this.isExecuted = true;
    }

    /// <inheritdoc/>
    public void Undo()
    {
        if (!this.isExecuted)
        {
            return;
        }

        this.repository.Add(this.user);
    }
}
