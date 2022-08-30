using ProgressiveBuilder.Products;

namespace ProgressiveBuilder.Builders
{
    public class DessertBuilder
    {
        private MenuDealBuilder menuDealBuilder;
        private MenuDeal menuDeal;

        private Dessert dessert;

        public DessertBuilder(MenuDealBuilder menuDealBuilder, MenuDeal menuDeal)
        {
            this.menuDealBuilder = menuDealBuilder;
            this.menuDeal = menuDeal;

            dessert = new Dessert();
        }

        public DessertBuilder WithItem(string item)
        {
            dessert.Item = item;
            return this;
        }

        public DessertBuilder WithSize(string size)
        {
            dessert.Size = size;
            return this;
        }

        public MenuDeal Build()
        {
            menuDeal.Dessert = dessert;
            return menuDeal;
        }
    }
}
