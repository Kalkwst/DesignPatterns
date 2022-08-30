using ProgressiveBuilder.Builders;

var menuBuilder = new MenuDealBuilder();
var menu = menuBuilder
    .AddSideDish()
        .WithItem("Breaded All-White Chicken Breast, Baked in Stone Oven")
        .WithDip("Frank's Spicy Buffalo")
        .WithSize("Large")
    .AddSideDish()
        .WithItem("Gluten Free Corn Tortilla Chips")
        .WithDip("Guacamole")
        .WithSize("Large")
    .AddSaladDish()
        .WithBase("Fresh Mixed Lettuce")
        .WithVeggies("Chopped Onions, Green Bell Peppers, Black Olives, Mushrooms")
        .WithMeats("Fajita Chicken, Bacon Bits")
        .WithCheeses("Mozzarella")
        .WithDressing("Zesty Italian")
    .AddPizzaDish()
        .WithDough("Sourdough with Cream Cheese Crust")
        .WithSauce("Tomato Sauce")
        .WithMeats("Beef, Sausage, Pepperoni")
        .WithVeggies("Mushrooms, Green Bell Peppers, Onions")
        .WithCheeses("Mozzarella")
    .AddDrink()
        .WithItem("Soda")
        .WithSize("Large")
    .AddDesert()
        .WithItem("Cookie Dough Ice Cream")
        .WithSize("Large")
    .Build();

menu.Display();
