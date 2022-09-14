using VisitorDoubleDispatch.DoubleDispatch.Probes;
using VisitorDoubleDispatch.DoubleDispatch.Soils;

namespace VisitorDoubleDispatch.DoubleDispatch
{
    public class DoubleDispatchRunner
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

            foreach (ISoil soil in soilsToBeVisited)
                soil.Accept(probe);
        }
    }
}
