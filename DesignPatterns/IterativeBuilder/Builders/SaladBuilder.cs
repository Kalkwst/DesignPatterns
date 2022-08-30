using ProgressiveBuilder.Products;

namespace ProgressiveBuilder.Builders
{
    public class SaladBuilder
    {
        private MenuDealBuilder menuDealBuilder;
        private MenuDeal menuDeal;

        private Salad salad;

        public SaladBuilder(MenuDealBuilder menuDealBuilder, MenuDeal menuDeal)
        {
            this.menuDealBuilder = menuDealBuilder;
            this.menuDeal = menuDeal;

            salad = new Salad();
        }

        public SaladBuilder WithBase(string saladBase)
        {
            salad.Base = saladBase;
            return this;
        }

        public SaladBuilder WithVeggies(string veggies)
        {
            salad.Veggies = veggies;
            return this;
        }

        public SaladBuilder WithMeats(string meats)
        {
            salad.Meats = meats;
            return this;
        }

        public SaladBuilder WithCheeses(string cheeses)
        {
            salad.Cheeses = cheeses;
            return this;
        }

        public SaladBuilder WithDressing(string dressing)
        {
            salad.Dressing = dressing;
            return this;
        }

        public PizzaBuilder AddPizzaDish()
        {
            menuDeal.Salad = salad;
            return new PizzaBuilder(menuDealBuilder, menuDeal);
        }
    }
}
