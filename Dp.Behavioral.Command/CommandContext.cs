namespace Dp.Behavioral.Command;

using System.Collections.Generic;

internal sealed class CommandContext
{
    private readonly Stack<ICommand> executedCommands = [];

    public Stack<ICommand> ExecutedCommands => this.executedCommands;

    public void Invoke(ICommand command)
    {
        if (command.CanExecute())
        {
            command.Execute();
            this.executedCommands.Push(command);
        }
    }

    public void Undo()
    {
        if (this.executedCommands.Count > 0)
        {
            this.executedCommands.Pop().Undo();
        }
    }

    public void UndoAll()
    {
        while (this.executedCommands.Count > 0)
        {
            this.executedCommands.Pop().Undo();
        }
    }
}
