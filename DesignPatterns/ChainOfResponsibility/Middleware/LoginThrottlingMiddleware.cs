namespace ChainOfResponsibility.Middleware;

public class LoginThrottlingMiddleware : BaseMiddleware
{
    private readonly int _requestsPerMinute;
    private int _requestCount;
    private long _currentTime;

    public LoginThrottlingMiddleware(int requestsPerMinute)
    {
        _requestsPerMinute = requestsPerMinute;
        _currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    }

    public override bool Check(string email, string password)
    {
        if (DateTimeOffset.Now.ToUnixTimeMilliseconds() > _currentTime + 60000)
        {
            _requestCount = 0;
            _currentTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        _requestCount++;

        if (_requestCount <= _requestsPerMinute) 
            return CheckNext(email, password);
        
        Console.WriteLine("Request limit exceeded. Please try again later.");
        return false;
    }
}