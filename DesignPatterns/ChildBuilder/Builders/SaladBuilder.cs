using ChildBuilder.Products;

namespace ChildBuilder.Builders
{
    public class SaladBuilder
    {
        private readonly DealBuilder _dealBuilder;
        private readonly Deal _deal;
        private readonly Salad _salad = new Salad();

        public SaladBuilder(DealBuilder parentBuilder, Deal deal)
        {
            _dealBuilder = parentBuilder;
            _deal = deal;
        }

        public SaladBuilder WithBase(string saladBase)
        {
            _salad.Base = saladBase;
            return this;
        }

        public SaladBuilder WithVeggies(string veggies)
        {
            _salad.Veggies = veggies;
            return this;
        }

        public SaladBuilder WithMeats(string meats)
        {
            _salad.Meats = meats;
            return this;
        }

        public SaladBuilder WithCheeses(string cheeses)
        {
            _salad.Cheeses = cheeses;
            return this;
        }

        public SaladBuilder WithDressing(string dressing)
        {
            _salad.Dressing = dressing;
            return this;
        }

        public DealBuilder BuildSalad()
        {
            _deal.Salad = _salad;
            return _dealBuilder;
        }
    }
}
