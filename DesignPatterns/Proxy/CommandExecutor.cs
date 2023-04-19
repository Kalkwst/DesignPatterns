using System.Diagnostics;

namespace Proxy;

public class CommandExecutor : ICommandExecutor
{
    public void RunCommand(string command)
    {
        // some heavy implementation
        var processInfo = new ProcessStartInfo()
        {
            FileName = "cmd.exe",
            WorkingDirectory = Environment.CurrentDirectory,
                Arguments = "/C " + command
        };

        using var process = Process.Start(processInfo);
        process.WaitForExit();
        Console.WriteLine("'" + command + "' command executed.");
    }
}