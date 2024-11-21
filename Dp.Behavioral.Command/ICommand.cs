namespace Dp.Behavioral.Command;

internal interface ICommand
{
    /// <summary>
    /// The execution part of the command.
    /// </summary>
    void Execute();

    /// <summary>
    /// Checks whether the command met the business requirements for execution.
    /// </summary>
    /// <returns>A flag indicating whether the command can be executed.</returns>
    bool CanExecute();

    /// <summary>
    /// Undo the operation.
    /// </summary>
    void Undo();
}
