using Visitor.Visitor;

namespace Visitor.Shapes
{
    public class Rectangle : IShape
    {
        public Guid Id { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Guid id, int x, int y, int width, int height)
        {
            Id = id;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitRectangle(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing rectangle-{Id} at ({X},{Y}) with width {Width} and height {Height}");
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
    }
}
