// See https://aka.ms/new-console-template for more information

using Proxy;

ICommandExecutor executor = new CommandExecutorProxy("admin", "wrong_pass");
try
{
    executor.RunCommand("dir");
    executor.RunCommand("rm -rf abc.pdf");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}