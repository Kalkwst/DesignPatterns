namespace Memento.Memento
{
    /// <summary>
    /// The Memento class
    /// </summary>
    public class FoodSupplierMemento
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public FoodSupplierMemento(string name, string phoneNumber, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
