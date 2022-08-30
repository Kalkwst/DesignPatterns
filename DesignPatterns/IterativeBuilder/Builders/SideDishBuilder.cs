using ProgressiveBuilder.Products;

namespace ProgressiveBuilder.Builders
{
    public class SideDishBuilder
    {
        private MenuDealBuilder menuDealBuilder;
        private MenuDeal menuDeal;

        private Side sideDish;

        public SideDishBuilder(MenuDealBuilder menuDealBuilder, MenuDeal menuDeal)
        {
            this.menuDealBuilder = menuDealBuilder;
            this.menuDeal = menuDeal;
            sideDish = new Side();
        }
        
        public SideDishBuilder WithItem(string item)
        {
            sideDish.Item = item;
            return this;
        }

        public SideDishBuilder WithDip(string dip)
        {
            sideDish.Dip = dip;
            return this;
        }

        public SideDishBuilder WithSize(string size)
        {
            sideDish.Size = size;
            return this;
        }

        public SideDishBuilder AddSideDish()
        {
            menuDeal.Sides.Add(sideDish);
            return new SideDishBuilder(menuDealBuilder, menuDeal);
        }

        public SaladBuilder AddSaladDish()
        {
            menuDeal.Sides.Add(sideDish);
            return new SaladBuilder(menuDealBuilder, menuDeal);
        }
    }
}