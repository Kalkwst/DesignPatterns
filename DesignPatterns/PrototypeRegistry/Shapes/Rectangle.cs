namespace PrototypeRegistry.Shapes;

public class Rectangle : Shape
{
    public int Width;
    public int Height;

    public Rectangle()
    {
    }

    public Rectangle(Rectangle target) : base(target)
    {
        if (target != null)
        {
            this.Width = target.Width;
            this.Height = target.Height;
        }
    }

    public override Shape Clone()
    {
        return new Rectangle(this);
    }

    public override bool Equals(object object2)
    {
        if (!(object2 is Rectangle) || !base.Equals(object2)) return false;
        Rectangle shape2 = (Rectangle)object2;
        return shape2.Width == Width && shape2.Height == Height;
    }

    public override int GetHashCode()
    {
        int hashCode = base.GetHashCode();
        hashCode = hashCode * 31 + Width.GetHashCode();
        hashCode = hashCode * 31 + Height.GetHashCode();
        return hashCode;
    }
}
