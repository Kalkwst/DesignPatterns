using ChildBuilder.Builders;

var deal = new DealBuilder()
    .AddSide()
        .WithItem("Spicy Loaded Pepperoni Wedges")
        .WithDip("Mayo")
        .WithSize("Large")
        .BuildSide()
    .AddSide()
        .WithItem("Spicy Cheesy Pepperoni Garlic Bread")
        .WithDip("BBQ Sauce")
        .WithSize("Large")
        .BuildSide()
    .AddSalad()
        .WithBase("Lettuce")
        .WithVeggies("Cherry Tomatoes, Red Cabbage, Carrot")
        .WithDressing("Garlic & Herbs")
        .BuildSalad()
    .Build();

deal.Display();