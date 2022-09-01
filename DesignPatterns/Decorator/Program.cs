using Decorator.Components;
using Decorator.Decorators;

Salad caesarSalad = new("Crisp Romaine Lettuce", "Parmesan Cheese", "Homemade Caesar Dressing");
caesarSalad.Display();

Pasta fetuccine = new("Homemade Fetuccine", "Creamy Garlic Alfredo Sauce");
fetuccine.Display();

Console.WriteLine("\nChanging availability of the dishes");

AvailabilityDecorator caesarAvailability = new(caesarSalad, 3);
AvailabilityDecorator pastaAvailability = new(fetuccine, 4);

caesarAvailability.OrderItem("Marion");
caesarAvailability.OrderItem("Thomas");
caesarAvailability.OrderItem("Imogen");
caesarAvailability.OrderItem("Jude");

pastaAvailability.OrderItem("Marion");
pastaAvailability.OrderItem("Thomas");
pastaAvailability.OrderItem("Imogen");
pastaAvailability.OrderItem("Jude");
pastaAvailability.OrderItem("Jacinth");

caesarAvailability.Display();
pastaAvailability.Display();

Console.ReadLine();


