using PrototypeRegistry.Shapes;

namespace PrototypeRegistry.Registry;

public class BundledShapeRegistry
{
    private Dictionary<string, Shape> cache = new Dictionary<string, Shape>();

    public BundledShapeRegistry()
    {
        Circle circle = new Circle();
        circle.x = 5;
        circle.y = 7;
        circle.Radius = 45;
        circle.color = "Green";

        Rectangle rectangle = new Rectangle();
        rectangle.x = 6;
        rectangle.y = 9;
        rectangle.Width = 8;
        rectangle.Height = 10;
        rectangle.color = "Blue";

        cache.Add("Big green circle", circle);
        cache.Add("Medium blue rectangle", rectangle);
    }

    public Shape Put(string key, Shape shape)
    {
        cache[key] = shape;
        return shape;
    }

    public Shape Get(string key)
    {
        return cache[key].Clone();
    }
}