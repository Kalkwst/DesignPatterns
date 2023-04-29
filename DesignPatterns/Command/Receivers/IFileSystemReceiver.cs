namespace Command.Receivers;

public interface IFileSystemReceiver
{
    public void OpenFile();
    public void WriteFile();
    public void CloseFile();
}