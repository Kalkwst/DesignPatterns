namespace PrototypeRegistry.Shapes;

public class Circle : Shape
{
    public int Radius;

    public Circle()
    {
    }

    public Circle(Circle target) : base(target)
    {
        if (target != null)
        {
            this.Radius = target.Radius;
        }
    }

    public override Shape Clone()
    {
        return new Circle(this);
    }

    public override bool Equals(object object2)
    {
        if (!(object2 is Circle shape2) || !base.Equals(shape2)) return false;
        return shape2.Radius == Radius;
    }

    public override int GetHashCode()
    {
        var hashCode = base.GetHashCode();
        hashCode = hashCode * 31 + Radius.GetHashCode();
        return hashCode;
    }
}