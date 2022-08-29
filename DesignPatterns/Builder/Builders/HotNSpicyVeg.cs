using Builder.Products;

namespace Builder.Builders
{
    /// <summary>
    /// A ConcreteBuilder class
    /// </summary>
    class HotNSpicyVeg : PizzaBuilder
    {
        public HotNSpicyVeg()
        {
            pizza = new Pizza("Hot 'N' Spicy Veg");
        }

        public override void AddDough()
        {
            pizza["dough"] = "12-grain pizza dough";
        }

        public override void AddSauce()
        {
            pizza["sauce"] = "Tomato base";
        }

        public override void AddMeats()
        {
            pizza["meats"] = "";
        }

        public override void AddCheeses()
        {
            pizza["cheeses"] = "Signature triple cheese blend, mozzarella";
        }

        public override void AddVeggies()
        {
            pizza["veggies"] = "Mushrooms, Peppers, Red Onions";
        }

        public override void AddExtras()
        {
            pizza["extras"] = "Jalapenos";
        }
    }
}
