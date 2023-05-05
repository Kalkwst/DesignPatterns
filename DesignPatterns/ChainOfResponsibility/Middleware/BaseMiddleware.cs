namespace ChainOfResponsibility.Middleware;

public abstract class BaseMiddleware
{
    private BaseMiddleware? _nextHandler = null;

    public static BaseMiddleware Link(BaseMiddleware head, params BaseMiddleware[] chain)
    {
        var internalHead = head;
        foreach(var nextLink in chain)
        {
            internalHead._nextHandler = nextLink;
            internalHead = nextLink;
        }

        return head;
    }

    public abstract bool Check(string email, string password);

    /// <summary>
    /// Runs the check of the next object in the chain or ends traversal if this is the last object.
    /// </summary>
    /// <param name="email">The email to check</param>
    /// <param name="password">The password to check</param>
    /// <returns>The result of the next check in the chain, or true if this is the last link.</returns>
    protected bool CheckNext(string email, string password)
    {
        return _nextHandler == null || _nextHandler.Check(email, password);
    }
}