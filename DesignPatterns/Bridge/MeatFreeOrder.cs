namespace Bridge
{
    /// <summary>
    /// RefinedAbstraction for a meat-free order
    /// </summary>
    public class MeatFreeOrder : OrderHandler
    {
        public override void SendOrder()
        {
            _restaurant.Place("Meat-Free Order");
        }
    }
}
