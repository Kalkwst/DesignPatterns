using VisitorDoubleDispatch.SingleDispatch.Soils;

namespace VisitorDoubleDispatch.SingleDispatch.Probes
{
    public interface IProbe
    {
        public void Visit(Loam loam);
        public void Visit(Peat peat);
        public void Visit(Podzol podzol);
        public void Visit(ISoil soil);
    }
}
