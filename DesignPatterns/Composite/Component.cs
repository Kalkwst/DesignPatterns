namespace Composite
{
    /// <summary>
    /// Component abstract class
    /// </summary>
    public abstract class Component
    {
        public int HitPoints { get; set; }

        public List<Component> Flavors { get; set; }

        public Component(int hitPoints)
        {
            HitPoints = hitPoints;
            Flavors = new List<Component>();
        }

        /// <summary>
        /// Return all available flavors and their hitpoints
        /// </summary>
        public void DisplayHitPoints()
        {
            foreach(var drink in this.Flavors)
            {
                drink.DisplayHitPoints();
                this.HitPoints += drink.HitPoints;
            }

            Console.WriteLine($"{this.GetType().Name}: {this.HitPoints} hitpoints.");
        }
    }
}
