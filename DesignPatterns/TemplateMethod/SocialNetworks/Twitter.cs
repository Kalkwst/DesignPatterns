namespace TemplateMethod.SocialNetworks;

public class Twitter : SocialNetwork
{
    public Twitter(string username, string password)
    {
        base.username = username;
        base.password = password;
    }

    protected override bool LogIn(string username, string password)
    {
        Console.WriteLine("\nChecking user's credentials");
        Console.WriteLine($"Name: {username}");
        Console.Write("Password: ");
        
        for(var i = 0; i < password.Length; i++)
            Console.Write("*");

        SimulateLatency();
        Console.WriteLine("\n\nTwitter login successful");
        return true;
    }

    protected override bool SendData(byte[] data)
    {
        Console.WriteLine($"Message was posted successfully on Twitter");
        return true;
    }

    protected override void LogOut()
    {
        Console.WriteLine($"User '{username}' was logged out from Twitter");
    }

    private void SimulateLatency()
    {
        var i = 0;
        var end = new Random().Next(5, 15);
        
        Console.WriteLine();
        while (i < end)
        {
            Console.Write(".");
            Thread.Sleep(new Random().Next(200, 800));
            i++;
        }
    }
}