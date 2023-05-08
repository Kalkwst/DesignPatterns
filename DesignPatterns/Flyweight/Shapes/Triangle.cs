namespace Flyweight.Shapes;

public class Triangle : IShape
{
    private bool _fill;

    public Triangle(bool fill)
    {
        _fill = fill;
        Console.WriteLine($"Creating triangle with fill: {_fill}");
        
        System.Threading.Thread.Sleep(800);
    }

    public void Draw(Graphics g, int x, int y, int width, int height, Color color)
    {
        var points = new Point[3];
        points[0] = new Point(x + width / 2, y);
        points[1] = new Point(x, y + height);
        points[2] = new Point(x + width, y + height);

        g.DrawPolygon(new Pen(color), points);

        if (_fill)
        {
            g.FillPolygon(new SolidBrush(color), points);
        }
    }
}