using Visitor.Shapes;

namespace Visitor.Visitor
{
    public interface IVisitor
    {
        public string VisitDot(Dot dot);
        public string VisitCircle(Circle circle);
        public string VisitRectangle(Rectangle rectangle);
        public string VisitComplex(ComplexShape complexShape);
    }
}
