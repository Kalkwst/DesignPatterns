using System.Text.RegularExpressions;
using Spectre.Console;

namespace Strategy.Strategies;

public class CreditCardPayment : IPaymentStrategy
{
    private bool _isValidated;

    public bool Pay(int amount)
    {
        if (!_isValidated)
            return false;
        
        AnsiConsole.WriteLine($"[green]Paying {amount} using Credit Card.[/]");
        return true;
    }

    public void Authenticate()
    {
        var creditCardNumber = AnsiConsole.Prompt(
            new TextPrompt<string>("Enter your card number: ")
                .ValidationErrorMessage("[red]Please enter a valid card number[/]")
                .Validate(e =>
                {
                    return Regex.IsMatch(e, @"\b\d{4}(| |-)\d{4}\1\d{4}\1\d{4}\b",
                            RegexOptions.IgnoreCase) switch
                        {
                            false => ValidationResult.Error("[red]Provide a valid card number[/]"),
                            _ => ValidationResult.Success()
                        };
                }));

        var creditCardExpiration = AnsiConsole.Prompt(
            new TextPrompt<string>("Enter your card expiration date: ")
                .ValidationErrorMessage("[red]Please enter a valid date[/]")
                .Validate(e =>
                {
                    return Regex.IsMatch(e, @"\d{2}/\d{4}",
                            RegexOptions.IgnoreCase) switch
                        {
                            false => ValidationResult.Error("[red]Please enter a valid date[/]"),
                            _ => ValidationResult.Success()
                        };
                }));
        
        var creditCardCVV = AnsiConsole.Prompt(
            new TextPrompt<string>("Enter your card verification value: ")
                .ValidationErrorMessage("[red]Please enter a valid card verification value[/]")
                .Validate(e =>
                {
                    return Regex.IsMatch(e, @"\d{3}",
                            RegexOptions.IgnoreCase) switch
                        {
                            false => ValidationResult.Error("[red]Please enter a valid card verification value[/]"),
                            _ => ValidationResult.Success()
                        };
                }));
        
        AnsiConsole.WriteLine($"Card Number: [cyan]{creditCardNumber}[/]");
        AnsiConsole.WriteLine($"Card Expiration Date: [cyan]{creditCardExpiration}[/]");
        AnsiConsole.WriteLine($"Card CVV: [cyan]{creditCardCVV}[/]");
        
        // Validate the card...
        _isValidated = true;
    }
}