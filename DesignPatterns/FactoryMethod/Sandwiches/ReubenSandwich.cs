using FactoryMethod.Ingredients;

namespace FactoryMethod.Sandwiches
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class ReubenSandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new CornedBeef());
            Ingredients.Add(new Sauerkraut());
            Ingredients.Add(new SwissCheese());
            Ingredients.Add(new ThousandIslandsSauce());
            Ingredients.Add(new Bread());
        }
    }
}
