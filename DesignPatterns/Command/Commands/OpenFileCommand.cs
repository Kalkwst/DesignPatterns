using Command.Receivers;

namespace Command.Commands;

public class OpenFileCommand : ICommand
{
    private readonly IFileSystemReceiver _fileSystemReceiver;

    public OpenFileCommand(IFileSystemReceiver fileSystemReceiver)
    {
        _fileSystemReceiver = fileSystemReceiver;
    }

    public void Execute()
    {
        _fileSystemReceiver.OpenFile();
    }
}