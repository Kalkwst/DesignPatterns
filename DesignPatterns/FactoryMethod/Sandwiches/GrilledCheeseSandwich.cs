using FactoryMethod.Ingredients;

namespace FactoryMethod.Sandwiches
{
    public class GrilledCheeseSandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new SwissCheese());
            Ingredients.Add(new Bread());
        }
    }
}
