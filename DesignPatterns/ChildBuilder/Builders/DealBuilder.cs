using ChildBuilder.Products;

namespace ChildBuilder.Builders
{
    public class DealBuilder
    {
        private readonly Deal deal = new Deal();

        public DealBuilder()
        {
            deal.Sides = new List<Side>();
        }

        public SaladBuilder AddSalad()
        {
            return new SaladBuilder(this, deal);
        }

        public SideBuilder AddSide()
        {
            return new SideBuilder(this, deal);
        }

        public Deal Build()
        {
            return deal;
        }
    }
}

