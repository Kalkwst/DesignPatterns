using AbstractFactory.Buttons;
using AbstractFactory.Checkboxes;
using AbstractFactory.Factories;
using AbstractFactory.Panels;

namespace AbstractFactory.App
{
    /// <summary>
    /// Factory users don't care which concrete factory they use since they work with
    /// factories and products through abstract interfaces.
    /// </summary>
    public class Application
    {
        private IButton button;
        private ICheckbox checkbox;
        private IPanel panel;

        public Application(IGUIFactory factory)
        {
            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
            panel = factory.CreatePanel();
        }

        public void Paint()
        {
            button.Paint();
            checkbox.Paint();
            panel.Paint();
        }
    }
}
