namespace Command.Receivers;

public class WindowsFileSystemReceiver : IFileSystemReceiver
{
    public void OpenFile()
    {
        Console.WriteLine("Opening file in Windows OS");
    }

    public void WriteFile()
    {
        Console.WriteLine("Writing file in Windows OS");
    }

    public void CloseFile()
    {
        Console.WriteLine("Closing file in Windows OS");
    }
}