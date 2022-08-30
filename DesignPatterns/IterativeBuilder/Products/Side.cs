namespace ProgressiveBuilder.Products
{
    public class Side
    {
        public string Item { get; set; }
        public string Dip { get; set; }
        public string Size { get; set; }

        public void Display()
        {
            Console.WriteLine("\n--------- Side Dish ---------");
            Console.WriteLine($"Item: {Item}");
            Console.WriteLine($"Dip: {Dip}");
            Console.WriteLine($"Size: {Size}");
        }
    }
}
