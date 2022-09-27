namespace Iterator.Collection
{
    public class EveryFlavorBean
    {
        private readonly string flavor;

        public EveryFlavorBean(string flavor)
        {
            this.flavor = flavor;
        }

        public string Flavor
        {
            get { return flavor; }
        }
    }
}
