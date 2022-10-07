using Memento.Memento;

namespace Memento.Caretaker
{
    /// <summary>
    /// The Caretaker class.  
    /// This class never examines the contents of any Memento and is
    /// responsible for keeping that memento.
    /// </summary>
    public class SupplierMemory
    {
        private FoodSupplierMemento memento;

        public FoodSupplierMemento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
