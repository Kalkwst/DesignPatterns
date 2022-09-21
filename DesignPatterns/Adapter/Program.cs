// Non-adapted
using Adapter;

Meats unknown = new Meats("Beef");
unknown.LoadData();

// Adapted
MeatDetails beef = new MeatDetails("Beef");
beef.LoadData();

MeatDetails chicken = new MeatDetails("Chicken");
chicken.LoadData();

MeatDetails turkey = new MeatDetails("Turkey");
turkey.LoadData();
