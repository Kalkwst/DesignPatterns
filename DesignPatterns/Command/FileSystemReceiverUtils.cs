using Command.Receivers;

namespace Command;

public class FileSystemReceiverUtils
{
    public static IFileSystemReceiver GetFileSystemReceiver()
    {
        var osName = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
        Console.WriteLine($"Underlying OS: {osName}");

        if (osName.Contains("Windows"))
            return new WindowsFileSystemReceiver();

        return new UnixFileSystemReceiver();
    }
}