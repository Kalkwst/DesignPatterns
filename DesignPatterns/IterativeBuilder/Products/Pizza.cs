namespace ProgressiveBuilder.Products
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Cheeses { get; set; }
        public string Meats { get; set; }
        public string Veggies { get; set; }
        public string Extras { get; set; }

        public void Display()
        {
            Console.WriteLine("\n--------- Pizza Dish ---------");
            Console.WriteLine($"Dough: {Dough}");
            Console.WriteLine($"Sauce: {Sauce}");
            Console.WriteLine($"Cheeses: {Cheeses}");
            Console.WriteLine($"Meats: {Meats}");
            Console.WriteLine($"Veggies: {Veggies}");
            Console.WriteLine($"Extras: {Extras}");
        }
    }
}
