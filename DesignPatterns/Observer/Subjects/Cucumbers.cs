namespace Observer.Subjects
{
    /// <summary>
    /// A ConcreteSubject class
    /// </summary>
    public class Cucumbers : Goods
    {
        public static string Name = "Cucumbers";

        public Cucumbers(double pricePerKilo) : base(pricePerKilo)
        {
        }
    }
}
