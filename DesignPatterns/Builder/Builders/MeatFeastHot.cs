using Builder.Products;

namespace Builder.Builders
{
    /// <summary>
    /// A Concrete builder class
    /// </summary>
    public class MeatFeastHot : PizzaBuilder
    {
        public MeatFeastHot()
        {
            pizza = new Pizza("Meat Feast Hot");
        }

        public override void AddDough()
        {
            pizza["dough"] = "Wheat pizza dough";
        }

        public override void AddSauce()
        {
            pizza["sauce"] = "Tomato base";
        }

        public override void AddMeats()
        {
            pizza["meats"] = "Pepperoni, Ham, Beef, Chicken";
        }

        public override void AddCheeses()
        {
            pizza["cheeses"] = "Signature triple cheese blend, mozzarella";
        }

        public override void AddVeggies()
        {
            pizza["veggies"] = "";
        }

        public override void AddExtras()
        {
            pizza["extras"] = "jalapenos";
        }
    }
}
