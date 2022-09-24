using AbstractFactory.Buttons;
using AbstractFactory.Checkboxes;
using AbstractFactory.Panels;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Each concrete factory extends basic factory and responsible for creating 
    /// products of a single variety.
    /// </summary>
    public class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }

        public IPanel CreatePanel()
        {
            return new MacOSPanel();
        }
    }
}
