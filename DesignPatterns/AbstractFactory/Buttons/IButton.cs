namespace AbstractFactory.Buttons
{
    /// <summary>
    /// The Abstract Factory pattern assumes that we have several families
    /// of products, structured into separate class hierarchies (Button/Checkbox/Panel).
    /// All products of the same family have a common interface. 
    /// 
    /// This is the common interface for buttons family.
    /// </summary>
    public interface IButton
    {
        public void Paint();
    }
}
