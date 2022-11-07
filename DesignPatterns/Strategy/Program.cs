using Spectre.Console;
using Strategy.Orders;
using Strategy.Strategies;

public class Program
{
    private static Dictionary<string, int> _products;
    private static Order order;
    private static IPaymentStrategy strategy;

    private static void Initialize()
    {
        _products = new Dictionary<string, int>
            { { "Motherboard", 220 }, { "CPU", 180 }, { "HDD", 60 }, { "RAM", 120 } };
        order = new Order();
    }

    public static void Main()
    {
        Initialize();
        
        while (!order.IsClosed())
        {
            do
            {
                var products = AnsiConsole.Prompt(
                    new MultiSelectionPrompt<string>()
                        .Title("What [green]products[/] do you want to add to the cart?")
                        .Required()
                        .PageSize(10)
                        .MoreChoicesText("[grey](Move up and down to reveal more products)[/]")
                        .InstructionsText(
                            "[grey](Press [blue]<space>[/] to toggle a product, " +
                            "[green]<enter>[/] to accept)[/]")
                        .AddChoices(new[]
                        {
                            "Motherboard", "CPU", "HDD", "RAM",
                        }));

                foreach (string product in products)
                {
                    order.AddCost(_products[product]);
                }
            } while (!AnsiConsole.Confirm("Go to payment?"));
            
            order.Close();

            if (strategy == null)
            {
                var paymentMethod = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select payment method:")
                        .PageSize(5)
                        .MoreChoicesText("[grey](Move up and down to reveal more payment methods)[/]")
                        .AddChoices(new[]
                        {
                            "Skrill",
                            "Credit Card"
                        })
                );

                strategy = paymentMethod.Equals("Skrill") ? new SkrillPayment() : new CreditCardPayment();
                order.ProcessOrder(strategy);

                Console.Read();
            }
        }
    }
}