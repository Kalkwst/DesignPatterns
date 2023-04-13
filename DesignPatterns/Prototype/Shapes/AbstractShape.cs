namespace Prototype;

/// <summary>
/// The Prototype abstract class
/// </summary>
public abstract class Shape
{
    public int x;
    public int y;
    public string color;

    public Shape()
    {
    }

    public Shape(Shape target)
    {
        if (target != null)
        {
            this.x = target.x;
            this.y = target.y;
            this.color = target.color;
        }
    }

    public abstract Shape Clone();

    public override bool Equals(object object2)
    {
        if (!(object2 is Shape)) return false;
        Shape shape2 = (Shape)object2;
        return shape2.x == x && shape2.y == y && object.Equals(shape2.color, color);
    }
}
