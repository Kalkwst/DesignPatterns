using AbstractFactory.Buttons;
using AbstractFactory.Checkboxes;
using AbstractFactory.Panels;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Each concrete factory extends basic factory and responsible for creating 
    /// products of a single variety
    /// </summary>
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }

        public IPanel CreatePanel()
        {
            return new WindowsPanel();
        }
    }
}
