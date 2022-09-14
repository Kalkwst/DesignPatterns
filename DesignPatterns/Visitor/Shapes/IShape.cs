using Visitor.Visitor;

namespace Visitor.Shapes
{
    /// <summary>
    /// Common shape interface
    /// </summary>
    public interface IShape
    {
        public void Move(int x, int y);
        public void Draw();
        public string Accept(IVisitor visitor);
    }
}
