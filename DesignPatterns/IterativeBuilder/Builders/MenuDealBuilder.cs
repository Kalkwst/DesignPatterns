using ProgressiveBuilder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressiveBuilder.Builders
{
    public class MenuDealBuilder
    {
        private readonly MenuDeal menuDeal;

        public MenuDealBuilder()
        {
            menuDeal = new MenuDeal();
        }

        public SideDishBuilder AddSideDish()
        {
            return new SideDishBuilder(this, menuDeal);
        }
    }
}
