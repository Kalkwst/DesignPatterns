using ChildBuilder.Products;

namespace ChildBuilder.Builders
{
    public class SideBuilder
    {
        private DealBuilder dealBuilder;
        private Deal deal;
        private Side side = new Side();

        public SideBuilder(DealBuilder dealBuilder, Deal deal)
        {
            this.dealBuilder = dealBuilder;
            this.deal = deal;
        }

        public SideBuilder WithItem(string item)
        {
            side.Item = item;
            return this;
        }

        public SideBuilder WithDip(string dip)
        {
            side.Dip = dip;
            return this;
        }

        public SideBuilder WithSize(string size)
        {
            side.Size = size;
            return this;
        }

        public DealBuilder BuildSide()
        {
            deal.Sides.Add(side);
            return dealBuilder;
        }
    }
}
