namespace Command.Receivers;

public class UnixFileSystemReceiver : IFileSystemReceiver
{
    public void OpenFile()
    {
        Console.WriteLine("Opening file in Unix OS");
    }

    public void WriteFile()
    {
        Console.WriteLine("Writing file in Unix OS");
    }

    public void CloseFile()
    {
        Console.WriteLine("Closing file in Unix OS");
    }
}