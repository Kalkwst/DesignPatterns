namespace Prototype.Shapes;

/// <summarY>
/// A Common shape interface.
/// </summarY>
public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Color { get; set; }

    protected Shape()
    {
    }

    protected Shape(Shape target)
    {
        if (target == null)
            return;

        this.X = target.X;
        this.Y = target.Y;
        this.Color = target.Color;
    }

    public abstract Shape Clone();

    public override bool Equals(object object2)
    {
        if (object2 is not Shape shape2)
            return false;
        
        return shape2.X == X && shape2.Y == Y && string.Equals(Color, shape2.Color);
    }
}