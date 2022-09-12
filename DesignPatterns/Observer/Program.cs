// Create price watch for cucumbers
using Observer.Observers;
using Observer.Subjects;

Restaurant bobsBurgers = new Restaurant("Bob's Burgers");
Restaurant krustyBurger = new Restaurant("Krusty Burger");
Restaurant carrotPalace = new Restaurant("Carrot Palace");

Cucumbers cucumbers = new Cucumbers(0.82);
Mutton mutton = new Mutton(12.9);

bobsBurgers.AddGoodsThreshold(cucumbers, 0.77);
bobsBurgers.AddGoodsThreshold(mutton, 10.8);

krustyBurger.AddGoodsThreshold(mutton, 8.2);

carrotPalace.AddGoodsThreshold(cucumbers, 0.89);

cucumbers.Attach(bobsBurgers);
cucumbers.Attach(carrotPalace);

mutton.Attach(krustyBurger);
mutton.Attach(bobsBurgers);

// Create price fluctuation
cucumbers.PricePerKilo = 0.78;
cucumbers.PricePerKilo = 0.65;
cucumbers.PricePerKilo = 1.02;

mutton.PricePerKilo = 12.0;
mutton.PricePerKilo = 10.2;
mutton.PricePerKilo = 6.81;

Console.ReadKey();