namespace Flyweight.Shapes;

public class Square : IShape
{
    private bool _fill;

    public Square(bool fill)
    {
        _fill = fill;
        Console.WriteLine($"Creating triangle with fill: {_fill}");
        
        System.Threading.Thread.Sleep(800);
    }

    public void Draw(Graphics g, int x, int y, int width, int height, Color color)
    {
        g.DrawRectangle(new Pen(color), x, y, width, height);
        if(_fill)
            g.FillRectangle(new SolidBrush(color), x, y, width, height);
    }
}