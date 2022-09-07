using FactoryMethod.Ingredients;

namespace FactoryMethod.Sandwiches
{
    /// <summary>
    /// Creator
    /// </summary>
    public abstract class Sandwich
    {
        private List<Ingredient> ingredients = new List<Ingredient>();

        public Sandwich()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
        }

        public void DisplayIngredients()
        {
            foreach (var ingredient in ingredients)
                Console.WriteLine(ingredient.GetType().Name);
        }
    }
}
