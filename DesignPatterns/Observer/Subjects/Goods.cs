using Observer.Observers;

namespace Observer.Subjects
{
    /// <summary>
    /// The Subject abstract class
    /// </summary>
    public abstract class Goods
    {
        private double pricePerKilo;
        private List<IRestaurant> restaurants = new List<IRestaurant>();

        protected Goods(double pricePerKilo)
        {
            this.pricePerKilo = pricePerKilo;
        }

        public void Attach(IRestaurant restaurant)
        {
            restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach(IRestaurant restaurant in restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine();
        }

        public double PricePerKilo
        {
            get { return pricePerKilo; }
            set
            {
                if(pricePerKilo != value)
                {
                    pricePerKilo = value;
                    Notify();
                }
            }
        }
    }
}
