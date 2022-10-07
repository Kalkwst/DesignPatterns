using Memento.Memento;

namespace Memento.Originator
{
    /// <summary>
    /// The Originator class, which is the class for which we want to save
    /// Mementos for its state.
    /// </summary>
    public class FoodSupplier
    {
        private string? name;
        private string? phoneNumber;
        private string? address;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                Console.WriteLine($"Proprietor: {name}");
            }
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                phoneNumber = value;
                Console.WriteLine($"Phone Number: {phoneNumber}");
            }
        }

        public string Address
        {
            get => address;
            set
            {
                address = value;
                Console.WriteLine($"Address: {address}");
            }
        }

        public FoodSupplierMemento SaveState()
        {
            Console.WriteLine("\nSaving current state\n");
            return new FoodSupplierMemento(name, phoneNumber, address);
        }

        public void RestoreState(FoodSupplierMemento memento)
        {
            Console.WriteLine("\nRestoring previous state\n");
            Name = memento.Name;
            PhoneNumber = memento.PhoneNumber;
            Address = memento.Address;
        }
    }
}
