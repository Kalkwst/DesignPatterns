namespace Bridge
{
    /// <summary>
    /// ConcreteImplementation for an ordering system at a fancy restaurant
    /// </summary>
    public class FineDiningRestaurantOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine($"Placing order for {order} at the Fine Dining Restaurant");

            if (order.Equals("Meat-Free Order"))
                Console.WriteLine("\tDish: Vegetarian Mushroom Risotto With Truffle Oil");
            if (order.Equals("Gluten-Free Order"))
                Console.WriteLine("\tDish: Arroz de Bacalhau");
        }
    }
}
