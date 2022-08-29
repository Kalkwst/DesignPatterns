
using FluentBuilder.Products;

namespace FluentBuilder.Builders
{
    public class FluentPizzaBuilder
    {
        private readonly Pizza pizza;

        public FluentPizzaBuilder(string pizzaName)
        {
            pizza = new Pizza(pizzaName);
        }

        public FluentPizzaBuilder WithDough(string dough)
        {
            pizza["dough"] = dough;
            return this;
        }

        public FluentPizzaBuilder WithSauce(string sauce)
        {
            pizza["sauce"] = sauce;
            return this;
        }

        public FluentPizzaBuilder WithMeat(string meat)
        {
            pizza["meats"] = meat;
            return this;
        }

        public FluentPizzaBuilder WithCheese(string cheese)
        {
            pizza["cheeses"] = cheese;
            return this;
        }

        public FluentPizzaBuilder WithVeggie(string veggie)
        {
            pizza["veggies"] = veggie;
            return this;
        }

        public FluentPizzaBuilder WithExtra(string extra)
        {
            pizza["extras"] = extra;
            return this;
        }

        public Pizza Build()
        {
            return pizza;
        }
    }
}
