using AbstractFactory.Buttons;
using AbstractFactory.Checkboxes;
using AbstractFactory.Panels;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// Each concrete factory extends basic factory and responsible for creating 
    /// products of a single variety
    /// </summary>
    public class LinuxFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }

        public IPanel CreatePanel()
        {
            return new LinuxPanel();
        }
    }
}
