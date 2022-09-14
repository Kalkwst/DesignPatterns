using Visitor.Visitor;

namespace Visitor.Shapes
{
    public class Circle : IShape
    {
        public Guid Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; }

        public Circle(Guid id, int x, int y, int radius)
        {
            Id = id;
            X = x;
            Y = y;
            Radius = radius;
        }

        public new string Accept(IVisitor visitor)
        {
            return visitor.VisitCircle(this);
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing circle-{Id} at ({X},{Y}) with radius {Radius}");
        }
    }
}
