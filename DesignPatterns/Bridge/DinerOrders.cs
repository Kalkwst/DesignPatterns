namespace Bridge
{
    /// <summary>
    /// ConcreteImplementation for an ordering system at a diner.
    /// </summary>
    public class DinerOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine($"Placing order for {order} at the Diner");

            if (order.Equals("Meat-Free Order"))
                Console.WriteLine("\tDish: Bean & Halloumi Stew");
            if (order.Equals("Gluten-Free Order"))
                Console.WriteLine("\tDish: Stuffed Peppers");
        }
    }
}