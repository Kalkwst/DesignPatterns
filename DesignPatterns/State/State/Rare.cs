using State.Context;

namespace State.State
{
    /// <summary>
    /// A Concrete State class.
    /// </summary>
    public class Rare : Doneness
    {
        public Rare(Doneness state) : this(state.CurrentTemperature, state.Steak) { }

        public Rare(double currentTemperature, Steak steak)
        {
            this.currentTemperature = currentTemperature;
            this.steak = steak;
            isSafe = true;

            lowerTemperature = 49;
            upperTemperature = 54.4;
        }

        public override void DecreaseTemperature(double degrees)
        {
            currentTemperature -= degrees;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemperature < lowerTemperature)
                steak.State = new Uncooked(this);

            if (currentTemperature > upperTemperature)
                steak.State = new MediumRare(this);
        }

        public override void IncreaseTemperature(double degrees)
        {
            currentTemperature += degrees;
            DonenessCheck();
        }
    }
}
