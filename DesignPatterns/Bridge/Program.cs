using Bridge;

OrderHandler meatFreeOrderHandler = new MeatFreeOrder
{
    _restaurant = new DinerOrders()
};
meatFreeOrderHandler.SendOrder();

meatFreeOrderHandler._restaurant = new FineDiningRestaurantOrders();
meatFreeOrderHandler.SendOrder();

Console.WriteLine();

OrderHandler glutenFreeOrderHandler = new GlutenFreeOrder
{
    _restaurant = new DinerOrders()
};
glutenFreeOrderHandler.SendOrder();

glutenFreeOrderHandler._restaurant = new FineDiningRestaurantOrders();
glutenFreeOrderHandler.SendOrder();