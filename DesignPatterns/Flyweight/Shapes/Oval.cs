namespace Flyweight.Shapes;

public class Oval : IShape
{

    private bool _fill;

    public Oval(bool fill)
    {
        _fill = fill;
        Console.WriteLine($"Creating Oval object with fill: {fill}");
        
        // Simulate heavy computational work
        System.Threading.Thread.Sleep(2000);
    }

    public void Draw(Graphics g, int x, int y, int width, int height, Color color)
    {
        g.DrawEllipse(new Pen(color), x, y, width, height);
        if (_fill)
            g.FillEllipse(new SolidBrush(color), x, y, width, height);
    }
}