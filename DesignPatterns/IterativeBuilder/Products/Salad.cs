namespace ProgressiveBuilder.Products
{
    public class Salad
    {
        public string Base { get; set; }
        public string Veggies { get; set; }
        public string Meats { get; set; }
        public string Cheeses { get; set; }
        public string Dressing { get; set; }

        public void Display()
        {
            Console.WriteLine("\n--------- Salad Dish ---------");
            Console.WriteLine($"Base: {Base}");
            Console.WriteLine($"Veggies: {Veggies}");
            Console.WriteLine($"Meats: {Meats}");
            Console.WriteLine($"Cheeses: {Cheeses}");
            Console.WriteLine($"Dressing: {Dressing}");
        }
    }
}
