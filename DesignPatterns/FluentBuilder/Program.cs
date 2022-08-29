using FluentBuilder.Builders;

var pizzaBuilder = new FluentPizzaBuilder("Supreme");

var pizzaSupreme = pizzaBuilder
   .WithDough("12-grain pizza dough")
   .WithSauce("Tomato base")
   .WithMeat("Pepperoni, Seasoned Minced Beef, Spicy Pork Sausage")
   .WithVeggie("Mushroom, Mixed Peppers, Red Onions")
   .WithCheese("Mozzarella")
   .WithExtra("Jalapenos")
   .Build();

pizzaSupreme.Display();
