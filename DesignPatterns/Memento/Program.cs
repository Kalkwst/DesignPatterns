using Memento.Caretaker;
using Memento.Originator;

FoodSupplier supplier = new FoodSupplier
{
    Name = Faker.Name.FullName(),
    PhoneNumber = Faker.Phone.Number(),
    Address = Faker.Address.StreetAddress()
};

SupplierMemory memory = new SupplierMemory();
memory.Memento = supplier.SaveState();

supplier.Address = Faker.Address.StreetAddress();

supplier.RestoreState(memory.Memento);
