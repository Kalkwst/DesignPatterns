namespace Prototype.Shapes;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle()
    {
    }

    public Rectangle(Rectangle target) : base(target)
    {
        if (target == null)
            return;
        this.Width = target.Width;
        this.Height = target.Height;
    }

    public override Shape Clone()
    {
        return new Rectangle(this);
    }

    public override bool Equals(object object2)
    {
        if (object2 is not Rectangle rectangle2 || !base.Equals(object2))
            return false;

        return rectangle2.Width == Width && rectangle2.Height == Height;
    }
}