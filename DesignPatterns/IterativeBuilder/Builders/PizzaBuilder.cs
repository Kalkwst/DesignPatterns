using ProgressiveBuilder.Products;
 
namespace ProgressiveBuilder.Builders
{
    public class PizzaBuilder
    {
        private MenuDealBuilder menuDealBuilder;
        private MenuDeal menuDeal;

        private Pizza pizza;

        public PizzaBuilder(MenuDealBuilder menuDealBuilder, MenuDeal menuDeal)
        {
            this.menuDealBuilder = menuDealBuilder;
            this.menuDeal = menuDeal;

            pizza = new Pizza();
        }

        public PizzaBuilder WithDough(string dough)
        {
            pizza.Dough = dough;
            return this;
        }

        public PizzaBuilder WithSauce(string sauce)
        {
            pizza.Sauce = sauce;
            return this;
        }

        public PizzaBuilder WithCheeses(string cheeses)
        {
            pizza.Cheeses = cheeses;
            return this;
        }

        public PizzaBuilder WithMeats(string meats)
        {
            pizza.Meats = meats;
            return this;
        }

        public PizzaBuilder WithVeggies(string veggies)
        {
            pizza.Veggies = veggies;
            return this;
        }

        public PizzaBuilder WithExtras(string extras)
        {
            pizza.Extras = extras;
            return this;
        }

        public DrinkBuilder AddDrink()
        {
            menuDeal.Pizza = pizza;
            return new DrinkBuilder(menuDealBuilder, menuDeal);
        }
    }
}
