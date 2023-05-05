namespace ChainOfResponsibility.Middleware;

public class AuthorizationMiddleware : BaseMiddleware
{
    public override bool Check(string email, string password)
    {
        if (email.Contains("admin"))
        {
            Console.WriteLine("Hello, admin!");
            return true;
        }
            
        Console.WriteLine("Hello, user!");
        return CheckNext(email, password);
    }
}