using Iterator.Collection;

namespace Iterator.Iterator
{
    public interface IBeanIterator
    {
        public EveryFlavorBean? First();
        public EveryFlavorBean? Next();
        public bool IsDone { get; }
        public EveryFlavorBean CurrentBean { get; }
    }
}
