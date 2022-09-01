using Decorator.Components;

namespace Decorator.Decorators
{
    /// <summary>
    /// The Abstract Base Decorator
    /// </summary>
    public abstract class AbstractDecorator : Dish
    {
        protected Dish _dish;

        protected AbstractDecorator(Dish dish)
        {
            _dish = dish;
        }

        public override void Display()
        {
            _dish.Display();
        }
    }
}
