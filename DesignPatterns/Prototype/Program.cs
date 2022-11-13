using Prototype.Shapes;

var shapes = new List<Shape>();
var clones = new List<Shape>();

var circle = new Circle
{
    X = 10,
    Y = 20,
    Color = "red",
    Radius = 12
};
shapes.Add(circle);
shapes.Add(circle.Clone());

var rectangle = new Rectangle
{
    X = 12,
    Y = 23,
    Color = "blue",
    Height = 32,
    Width = 12
};
shapes.Add(rectangle);
shapes.Add(rectangle.Clone());

CloneAndCompare(shapes, clones);

void CloneAndCompare(IReadOnlyList<Shape> shapes, List<Shape> clones)
{
    clones.AddRange(shapes.Select(shape => shape.Clone()));

    for (var i = 0; i < shapes.Count; i++)
    {
        if (shapes[i] != clones[i])
        {
            Console.WriteLine($"Index {i}: Shapes are different objects!");
            if (shapes[i].Equals(clones[i]))
            {
                Console.WriteLine($"Index {i}: And they are identical!");
            }
            else
            {
                throw new Exception("Shapes are not identical");
            }
        }
        else
        {
            throw new Exception("Shape objects are the same!");
        }
    }
}