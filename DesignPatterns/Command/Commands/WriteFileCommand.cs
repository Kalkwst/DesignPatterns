using Command.Receivers;

namespace Command.Commands;

public class WriteFileCommand : ICommand
{
    private readonly IFileSystemReceiver _fileSystemReceiver;

    public WriteFileCommand(IFileSystemReceiver fileSystemReceiver)
    {
        _fileSystemReceiver = fileSystemReceiver;
    }

    public void Execute()
    {
        _fileSystemReceiver.WriteFile();
    }
}