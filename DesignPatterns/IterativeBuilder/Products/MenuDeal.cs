using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressiveBuilder.Products
{
    public class MenuDeal
    {
        public List<Side> Sides { get; set; }
        public Salad Salad { get; set; }
        public Pizza Pizza { get; set; }
        public Drink Drink { get; set; }
        public Dessert Dessert { get; set; }

        public MenuDeal()
        {
            Sides = new List<Side>();
        }

        public void Display()
        {
            foreach (var side in Sides)
                side.Display();
            Salad.Display();
            Pizza.Display();
            Drink.Display();
            Dessert.Display();
        }
    }
}
