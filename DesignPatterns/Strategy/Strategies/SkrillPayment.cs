using System.Text.RegularExpressions;
using Spectre.Console;

namespace Strategy.Strategies;

/// <summary>
/// Concrete Strategy. Implements the Skrill payment method.
/// </summary>
public class SkrillPayment : IPaymentStrategy
{
    private static readonly Dictionary<string, string> Database = new();
    private string _email;
    private string _password;
    private bool _isSignedIn;

    public SkrillPayment()
    {
        Database.Add("user@example.com", "123456");
        _email = "";
        _password = "";
    }

    public bool Pay(int amount)
    {
        if (!_isSignedIn) 
            return false;
        
        AnsiConsole.WriteLine($"[green]Paying {amount} using PayPal.[/]");
        return true;
    }

    /// <summary>
    /// Authenticates the user.
    /// </summary>
    public void Authenticate()
    {
        while (!_isSignedIn)
        {
            _email = AnsiConsole.Prompt(
                new TextPrompt<string>("Enter your email:")
                    .ValidationErrorMessage("[red]Please enter a valid email[/]")
                    .Validate(e =>
                    {
                        return Regex.IsMatch(e, @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$",
                                RegexOptions.IgnoreCase) switch
                            {
                                false => ValidationResult.Error("[red]Provide a valid email address[/]"),
                                _ => ValidationResult.Success()
                            };
                    }));

            _password = AnsiConsole.Prompt(
                new TextPrompt<string>("Enter your password: ")
                    .PromptStyle("red")
                    .Secret());

            AnsiConsole.WriteLine(Verify()
                ? $"[green]Data verification is successful. Welcome {_email}[/]"
                : "[red]Wrong username or password.[/]");
        }
    }

    private bool Verify()
    {
        if (Database.ContainsKey(_email)) 
            _isSignedIn = _password.Equals(Database[_email]);
        return _isSignedIn;
    }
}