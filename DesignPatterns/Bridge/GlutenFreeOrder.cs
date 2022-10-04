namespace Bridge
{
    /// <summary>
    /// RefinedAbstraction for a gluten free order
    /// </summary>
    public class GlutenFreeOrder : OrderHandler
    {
        public override void SendOrder()
        {
            _restaurant.Place("Gluten-Free Order");
        }
    }
}
