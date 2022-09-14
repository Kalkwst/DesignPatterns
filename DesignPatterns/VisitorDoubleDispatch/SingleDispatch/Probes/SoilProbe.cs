using VisitorDoubleDispatch.SingleDispatch.Soils;

namespace VisitorDoubleDispatch.SingleDispatch.Probes
{
    public class SoilProbe : IProbe
    {
        public void Visit(Loam loam)
        {
            Console.WriteLine("Deploying tools specific to loam");
        }

        public void Visit(Peat peat)
        {
            Console.WriteLine("Deploying tools specific to peat");
        }

        public void Visit(Podzol podzol)
        {
            Console.WriteLine("Deploying tools specific to podzol");
        }

        public void Visit(ISoil soil)
        {
            Console.WriteLine("Cannot probe unknown soil");
        }
    }
}
