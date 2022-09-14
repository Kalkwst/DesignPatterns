using Visitor.Visitor;

namespace Visitor.Shapes
{
    public class Dot : IShape
    {
        public Guid Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Dot()
        {
        }

        public Dot(Guid id, int x, int y)
        {
            Id = id;
            X = x;
            Y = y;
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitDot(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing dot-{Id} at ({X},{Y})");
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
    }
}
