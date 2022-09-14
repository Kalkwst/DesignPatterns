using Visitor.Shapes;
using Visitor.Visitor;

public class Program
{
    public static void Main(string[] args)
    {
        Dot dot = new Dot(Guid.NewGuid(), 10, 12);
        Circle circle = new Circle(Guid.NewGuid(), 23, 15, 21);
        Rectangle rectangle = new Rectangle(Guid.NewGuid(), 10, 17, 20, 32);

        ComplexShape complex = new ComplexShape(Guid.NewGuid());
        complex.Add(dot);
        complex.Add(circle);
        complex.Add(rectangle);

        ComplexShape complexShapeDot = new ComplexShape(Guid.NewGuid());
        complexShapeDot.Add(dot);
        complex.Add(complexShapeDot);

        Export(dot, circle, complex);
    }

    private static void Export(params IShape[] shapes)
    {
        XMLExportVisitor xmlVisitor = new XMLExportVisitor();
        Console.WriteLine(xmlVisitor.Export(shapes));
    }
}




