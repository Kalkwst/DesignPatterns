using Iterator.Iterator;

namespace Iterator.Collection
{
    public class BertieBottsEveryFlavorBeanBox : ICandyCollection
    {
        private List<EveryFlavorBean> items = new();

        public IBeanIterator CreateIterator()
        {
            return new BeanIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(params string[] beans)
        {
            foreach(string bean in beans)
                items.Add(new EveryFlavorBean(bean));
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Add((EveryFlavorBean)value); }
        }
    }
}
