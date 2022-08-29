namespace Builder.Products
{
    /// <summary>
    /// The Product class
    /// </summary>
    public class Pizza
    {
        private readonly string pizzaName;
        private readonly Dictionary<string, string> ingredients =
            new();

        public Pizza(string pizzaName)
        {
            this.pizzaName = pizzaName;
        }

        // Indexer
        public string this[string key]
        {
            get { return ingredients[key]; }
            set { ingredients[key] = value; }
        }

        public void Display()
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine($"Pizza: {pizzaName}");

            Console.WriteLine($" Dough: {ingredients["dough"]}");
            Console.WriteLine($" Sauce: {ingredients["sauce"]}");
            Console.WriteLine($" Meats: {ingredients["meats"]}");
            Console.WriteLine($" Cheeses: {ingredients["cheeses"]}");
            Console.WriteLine($" Veggies: {ingredients["veggies"]}");
            Console.WriteLine($" Extras: {ingredients["extras"]}");
        }
    }
}
