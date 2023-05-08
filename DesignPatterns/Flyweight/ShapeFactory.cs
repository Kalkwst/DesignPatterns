using Flyweight.Shapes;

namespace Flyweight;

public class ShapeFactory
{
    private static readonly Dictionary<ShapeType, IShape> shapes = new Dictionary<ShapeType, IShape>();

    public static IShape GetShape(ShapeType type)
    {
        IShape _concreteShape = shapes.GetValueOrDefault(type, null);

        if (_concreteShape != null) 
            return _concreteShape;
        
        _concreteShape = type switch
        {
            ShapeType.LINE => new Line(),
            ShapeType.OVAL_FILL => new Oval(true),
            ShapeType.OVAL_NOFILL => new Oval(false),
            ShapeType.SQUARE_FILL => new Square(true),
            ShapeType.SQUARE_NOFILL => new Square(false),
            ShapeType.TRIANGLE_FILL => new Triangle(true),
            ShapeType.TRIANGLE_NOFILL => new Triangle(false),
            _ => _concreteShape
        } ?? throw new InvalidOperationException();
            
        shapes.Add(type, _concreteShape);

        return _concreteShape;
    }
}