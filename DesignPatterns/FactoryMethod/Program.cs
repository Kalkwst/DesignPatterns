using FactoryMethod.Sandwiches;

Console.WriteLine("Reuben Sandwich");
ReubenSandwich reubenSandwich = new ReubenSandwich();
reubenSandwich.DisplayIngredients();

Console.WriteLine("\n------------------------------------------\n");

Console.WriteLine("Grilled Cheese Sandwich");
GrilledCheeseSandwich grilledCheese = new GrilledCheeseSandwich();
grilledCheese.DisplayIngredients();
