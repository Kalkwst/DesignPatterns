using System.Text;

namespace TemplateMethod.SocialNetworks;

public abstract class SocialNetwork
{
    protected string username;
    protected string password;

    protected SocialNetwork()
    {
    }

    /// <summary>
    /// Publish a post to a social network.
    /// </summary>
    /// <param name="message">The message to post.</param>
    /// <returns>true if the message is successfully posted, false otherwise.</returns>
    public bool Post(string message)
    {
        if (!LogIn(username, password)) 
            return false;
        
        var result = SendData(Encoding.ASCII.GetBytes(message));
        LogOut();
        return result;

    }

    protected abstract bool LogIn(string username, string password);
    protected abstract bool SendData(byte[] data);
    protected abstract void LogOut();
}