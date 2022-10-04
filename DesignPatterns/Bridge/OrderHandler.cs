namespace Bridge
{
    /// <summary>
    /// Abstration which represents the sent order
    /// and manitains a reference to the restaurant where the order is going.
    /// </summary>
    public abstract class OrderHandler
    {
        public IOrderingSystem _restaurant;

        public abstract void SendOrder();
    }
}
