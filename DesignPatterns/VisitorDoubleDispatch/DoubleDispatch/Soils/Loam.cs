using VisitorDoubleDispatch.DoubleDispatch.Probes;

namespace VisitorDoubleDispatch.DoubleDispatch.Soils
{
    public class Loam : ISoil
    {
        public void Accept(IProbe probe)
        {
            probe.Visit(this);
        }

        public void DisplayName()
        {
            Console.WriteLine("Loam");
        }
    }
}
