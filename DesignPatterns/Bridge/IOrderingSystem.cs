namespace Bridge
{
    /// <summary>
    /// Implementation participant which defines an interface for placing an order
    /// </summary>
    public interface IOrderingSystem
    {
        public void Place(string order);
    }
}
