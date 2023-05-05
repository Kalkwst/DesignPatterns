// See https://aka.ms/new-console-template for more information

using ChainOfResponsibility;
using ChainOfResponsibility.Middleware;

class Program
{
    private static Server server;

    private static void Init()
    {
        server = new Server();
        server.Register("admin@gmail.com", "this_is_super_secure_admin_password");
        server.Register("user@gmail.com", "password123");

        BaseMiddleware middleware = BaseMiddleware.Link(
            new LoginThrottlingMiddleware(3),
            new AuthenticationMiddleware(server),
            new AuthorizationMiddleware());
        
        server.SetMiddleware(middleware);
    }

    public static void Main(string[] args)
    {
        Init();

        bool success;
        do
        {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            
            Console.Write("Input password: ");
            string password = Console.ReadLine();
            
            success = server.Login(email, password);
        } while (!success);
    }
}