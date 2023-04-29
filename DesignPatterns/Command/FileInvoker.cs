using Command.Commands;

namespace Command;

public class FileInvoker
{
    private readonly ICommand _command;

    public FileInvoker(ICommand command)
    {
        this._command = command;
    }

    public void Execute()
    {
        _command.Execute();
    }
}