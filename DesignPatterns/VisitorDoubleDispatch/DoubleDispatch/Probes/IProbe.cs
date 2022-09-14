using VisitorDoubleDispatch.DoubleDispatch.Soils;

namespace VisitorDoubleDispatch.DoubleDispatch.Probes
{
    public interface IProbe
    {
        public void Visit(Loam loam);
        public void Visit(Peat peat);
        public void Visit(Podzol podzol);
        public void Visit(ISoil soil);
    }
}
