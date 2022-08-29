using Builder.Builders;
using Builder.Directors;

public class Demo
{
    static void Main(string[] args)
    {
        PizzaBuilder builder;

        // Create a pizza assembly line
        AssemblyLine shop = new AssemblyLine();

        // Construct and display pizzas
        builder = new MeatFeastHot();
        shop.Assemble(builder);
        builder.Pizza.Display();

        builder = new HotNSpicyVeg();
        shop.Assemble(builder);
        builder.Pizza.Display();

        // Wait for user
        Console.ReadKey();
    }
}

