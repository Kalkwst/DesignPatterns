namespace Prototype.Shapes;

public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle()
    {
    }

    public Circle(Circle target) : base(target)
    {
        if (target == null)
            return;

        this.Radius = target.Radius;
    }

    public override Shape Clone()
    {
        return new Circle(this);
    }

    public override bool Equals(object object2)
    {
        if (object2 is not Circle circle2 || !base.Equals(object2))
            return false;

        return circle2.Radius == Radius;
    }
}