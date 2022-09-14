using VisitorDoubleDispatch.DoubleDispatch.Probes;

namespace VisitorDoubleDispatch.DoubleDispatch.Soils
{
    public interface ISoil
    {
        public void Accept(IProbe probe);
        public void DisplayName();
    }
}
