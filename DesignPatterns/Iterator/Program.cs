using Iterator.Collection;
using Iterator.Iterator;

BertieBottsEveryFlavorBeanBox beanBox = new();
beanBox.Add("Banana",
            "Black Pepper",
            "Blueberry",
            "Booger",
            "Candyfloss",
            "Cherry",
            "Cinnamon",
            "Dirt",
            "Earthworm",
            "Earwax",
            "Grass",
            "Green Apple",
            "Marshmallow",
            "Rotten Egg",
            "Sausage",
            "Lemon",
            "Soap",
            "Tutti-Frutti",
            "Vomit",
            "Watermelon");

BeanIterator iterator = (BeanIterator)beanBox.CreateIterator();

for(EveryFlavorBean item = iterator.First();
    !iterator.IsDone;
    item = iterator.Next())
{
    Console.WriteLine(item.Flavor);
}
