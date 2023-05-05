using System.Security.Cryptography;
using System.Text;
using ChainOfResponsibility.Middleware;

namespace ChainOfResponsibility;

public class Server
{
    private Dictionary<string, string> _users = new Dictionary<string, string>();
    private BaseMiddleware _middleware;

    public void SetMiddleware(BaseMiddleware middleware)
    {
        _middleware = middleware;
    }

    public bool Login(string email, string password)
    {
        if (_middleware.Check(email, password))
        {
            Console.WriteLine("Authorization successful");
            return true;
        }

        return false;
    }

    public void Register(string email, string password)
    {
        _users.Add(email, CalculateHash(password));
    }

    public bool EmailExists(string email)
    {
        return _users.ContainsKey(email);
    }

    public bool PassWordIsValid(string email, string password)
    {
        var provided = CalculateHash(password);
        return _users[email].Equals(provided);
    }

    private string CalculateHash(string value)
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(value);
        
        // Create an instance of the SHA-512 algorithm
        SHA512 sha512 = SHA512.Create();
        
        // Compute the has value of the input bytes
        byte[] hashBytes = sha512.ComputeHash(inputBytes);
        
        // Convert the hash bytes to a hex string
        StringBuilder sb = new StringBuilder();
        for (var i = 0; i < hashBytes.Length; i++)
            sb.Append(hashBytes[i].ToString("x2"));

        return sb.ToString();
    }
}