namespace ChainOfResponsibility.Middleware;

public class AuthenticationMiddleware : BaseMiddleware
{
    private readonly Server _server;

    public AuthenticationMiddleware(Server server)
    {
        _server = server;
    }

    public override bool Check(string email, string password)
    {
        if (!_server.EmailExists(email) || !_server.PassWordIsValid(email, password))
        {
            Console.WriteLine("Invalid username or password");
            return false;
        }

        return CheckNext(email, password);
    }
}