namespace ChildBuilder.Products
{
    public class Deal
    {
        public List<Side> Sides { get; set; }
        public Salad Salad { get; set; }

        public void Display()
        {
            foreach (var side in Sides)
            {
                Console.WriteLine($"Side: {side.Item}");
                Console.WriteLine($"Dip: {side.Dip}");
                Console.WriteLine($"Size: {side.Size}");
                Console.WriteLine();
            }

            Console.WriteLine("Salad:");
            Console.WriteLine($"Base: { Salad.Base}");
            Console.WriteLine($"Veggies: {Salad.Veggies}");
            Console.WriteLine($"Meats: {Salad.Meats}");
            Console.WriteLine($"Cheeses: {Salad.Cheeses}");
            Console.WriteLine($"Dressing: {Salad.Dressing}");
        }
    }
}
