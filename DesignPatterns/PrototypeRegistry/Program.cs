// See https://aka.ms/new-console-template for more information

using PrototypeRegistry.Registry;
using PrototypeRegistry.Shapes;

public class Program {
    public static void Main(string[] args)
    {
        BundledShapeRegistry cache = new BundledShapeRegistry();

        Shape shape1 = cache.Get("Big green circle");
        Shape shape2 = cache.Get("Medium blue rectangle");
        Shape shape3 = cache.Get("Medium blue rectangle");

        if (shape1 != shape2 && !shape1.Equals(shape2))
        {
            Console.WriteLine("Big green circle != Medium blue rectangle (yay!)");
        }
        else
        {
            Console.WriteLine("Big green circle == Medium blue rectangle (booo!)");
        }

        if (shape2 != shape3)
        {
            Console.WriteLine("Medium blue rectangles are two different objects (yay!)");
            if (shape2.Equals(shape3))
            {
                Console.WriteLine("And they are identical (yay!)");
            }
            else
            {
                Console.WriteLine("But they are not identical (booo!)");
            }
        }
        else
        {
            Console.WriteLine("Rectangle objects are the same (booo!)");
        }
    }
}