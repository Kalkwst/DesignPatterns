namespace Proxy;

public class CommandExecutorProxy : ICommandExecutor
{
    private bool _isAdmin = false;
    private ICommandExecutor _executor;

    public CommandExecutorProxy(string username, string password)
    {
        if ("admin".Equals(username) && "1234".Equals(password))
            _isAdmin = true;

        _executor = new CommandExecutor();
    }

    public void RunCommand(string command)
    {
        if(_isAdmin)
            _executor.RunCommand(command);
        else
        {
            if (command.Trim().StartsWith("rm"))
                throw new Exception("rm command is not allowed for non-admin users");
            else
                _executor.RunCommand(command);
        }
    }
}