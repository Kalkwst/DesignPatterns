using Command.Receivers;

namespace Command.Commands;

public class CloseFileCommand : ICommand
{
    private readonly IFileSystemReceiver _fileSystemReceiver;

    public CloseFileCommand(IFileSystemReceiver fileSystemReceiver)
    {
        _fileSystemReceiver = fileSystemReceiver;
    }

    public void Execute()
    {
        _fileSystemReceiver.CloseFile();
    }
}