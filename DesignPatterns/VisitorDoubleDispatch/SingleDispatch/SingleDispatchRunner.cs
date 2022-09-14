using VisitorDoubleDispatch.SingleDispatch.Probes;
using VisitorDoubleDispatch.SingleDispatch.Soils;

namespace VisitorDoubleDispatch.SingleDispatch
{
    public class SingleDispatchRunner
    {
        public static void Run()
        {
            ISoil loam = new Loam();
            ISoil peat = new Peat();
            ISoil podzol = new Podzol();

            IProbe probe = new SoilProbe();

            List<ISoil> soilsToBeVisited = new();

            soilsToBeVisited.Add(loam);
            soilsToBeVisited.Add(peat);
            soilsToBeVisited.Add(podzol);

            foreach(ISoil soil in soilsToBeVisited)
                probe.Visit(soil);
        }
    }
}
