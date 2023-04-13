using System;
using System.Collections.Generic;
using Prototype;

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        List<Shape> shapesCopy = new List<Shape>();

        Circle circle = new Circle();
        circle.x = 10;
        circle.y = 20;
        circle.Radius = 15;
        circle.color = "red";
        shapes.Add(circle);

        Circle anotherCircle = (Circle)circle.Clone();
        shapes.Add(anotherCircle);

        Rectangle rectangle = new Rectangle();
        rectangle.Width = 10;
        rectangle.Height = 20;
        rectangle.color = "blue";
        shapes.Add(rectangle);

        cloneAndCompare(shapes, shapesCopy);
    }

    private static void cloneAndCompare(List<Shape> shapes, List<Shape> shapesCopy)
    {
        shapesCopy.AddRange(shapes.Select(shape => shape.Clone()));

        for (var i = 0; i < shapes.Count; i++)
        {
            if (shapes[i] != shapesCopy[i])
            {
                Console.WriteLine(i + ": Shapes are different objects (Exquisite!)");
                if (shapes[i].Equals(shapesCopy[i]))
                {
                    Console.WriteLine(i + ": And they are identical (Charming!)");
                }
                else
                {
                    Console.WriteLine(i + ": But they are not identical (Obscene!)");
                }
            }
            else
            {
                Console.WriteLine(i + ": Shape objects are the same (Indecorous!)");
            }
        }
    }
}