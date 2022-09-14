using Visitor.Visitor;

namespace Visitor.Shapes
{
    public class ComplexShape : IShape
    {
        public Guid Id { get; set; }
        public List<IShape> children = new();

        public int X { get; set; }
        public int Y { get; set; }

        public ComplexShape(Guid id)
        {
            Id = id;
        }

        public void Add(IShape shape)
        {
            children.Add(shape);
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitComplex(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing complex-{Id} at ({X},{Y})");
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
    }
}
