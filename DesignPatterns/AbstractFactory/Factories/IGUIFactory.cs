using AbstractFactory.Buttons;
using AbstractFactory.Checkboxes;
using AbstractFactory.Panels;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Abstract factory knows about all (abstract) product types
    /// </summary>
    public interface IGUIFactory
    {
        public IButton CreateButton();
        public ICheckbox CreateCheckbox();
        public IPanel CreatePanel();
    }
}
