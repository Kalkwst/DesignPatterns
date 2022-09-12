using Observer.Subjects;

namespace Observer.Observers
{
    /// <summary>
    /// The ConcreteObserver class
    /// </summary>
    public class Restaurant : IRestaurant
    {
        private string name;
        private Dictionary<Goods, double> goodsThresholds;

        public Restaurant(string name)
        {
            this.name = name;
            goodsThresholds = new Dictionary<Goods, double>();
        }

        public void AddGoodsThreshold(Goods good, double threshold)
        {
            goodsThresholds.Add(good, threshold);
        }

        public void Update(Goods goods)
        {
            Console.WriteLine($"Notified {name} of {goods.GetType().Name}'s price change to {Math.Round(goods.PricePerKilo, 2)} per kilo");

            if (goods.PricePerKilo < goodsThresholds[goods])
                Console.WriteLine($"{name} wants to buy some {goods.GetType().Name}!");
        }
    }
}
