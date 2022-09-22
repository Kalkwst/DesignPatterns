using State.Context;

namespace State.State
{
    /// <summary>
    /// The State abstract class
    /// </summary>
    public abstract class Doneness
    {
        protected Steak steak;
        protected double currentTemperature;
        protected double lowerTemperature;
        protected double upperTemperature;
        protected bool isSafe;

        public Steak Steak
        {
            get { return steak; }
            set { steak = value; }
        }

        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }

        public abstract void IncreaseTemperature(double degrees);
        public abstract void DecreaseTemperature(double degrees);
        public abstract void DonenessCheck();
    }
}
