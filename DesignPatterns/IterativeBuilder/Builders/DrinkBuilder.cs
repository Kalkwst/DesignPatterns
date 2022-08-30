using ProgressiveBuilder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressiveBuilder.Builders
{
    public class DrinkBuilder
    {
        private MenuDealBuilder dealBuilder;
        private MenuDeal menuDeal;

        private Drink drink;

        public DrinkBuilder(MenuDealBuilder dealBuilder, MenuDeal menuDeal)
        {
            this.dealBuilder = dealBuilder;
            this.menuDeal = menuDeal;

            drink = new Drink();
        }

        public DrinkBuilder WithItem(string item)
        {
            drink.Item = item;
            return this;
        }

        public DrinkBuilder WithSize(string size)
        {
            drink.Size = size;
            return this;
        }

        public DessertBuilder AddDesert()
        {
            menuDeal.Drink = drink;
            return new DessertBuilder(dealBuilder, menuDeal);
        }
    }
}
