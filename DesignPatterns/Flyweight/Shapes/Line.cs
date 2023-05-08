namespace Flyweight.Shapes;

public class Line : IShape
{
    public Line()
    {
        Console.WriteLine("Creating a new line object");
        
        // Simulate heavy computation
        System.Threading.Thread.Sleep(1000);
    }

    public void Draw(Graphics g, int x1, int y1, int x2, int y2, Color color)
    {
        g.DrawLine(new Pen(color), x1, y1, x2, y2);
    }
}