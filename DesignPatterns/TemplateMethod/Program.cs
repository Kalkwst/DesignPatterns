// See https://aka.ms/new-console-template for more information

using TemplateMethod.SocialNetworks;

SocialNetwork network = null;

Console.Write("Enter your username: ");
var username = Console.ReadLine();
Console.Write("Enter your password: ");
var password = Console.ReadLine();
Console.Write("Enter your post message: ");
var message = Console.ReadLine();

Console.WriteLine(@"Choose the social network you want to post to:
                        1. Facebook\n
                        2. Twitter\n
                        3. Dev.to");
var choice = int.Parse(Console.ReadLine());

network = choice switch
{
    1 => new Facebook(username, password),
    2 => new Twitter(username, password),
    3 => new DevTo(username, password),
    _ => throw new Exception()
};

network.Post(message);

