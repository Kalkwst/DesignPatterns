using AbstractFactory.App;
using AbstractFactory.Factories;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {
        Application app = ConfigureApplication();
        app.Paint();
    }

    private static Application ConfigureApplication()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return new Application(new LinuxFactory());
        if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return new Application(new MacOSFactory());

        return new Application(new WindowsFactory());
    }
}
