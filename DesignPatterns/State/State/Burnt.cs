using State.Context;

namespace State.State
{
    public class Burnt : Doneness
    {
        public Burnt(Doneness state) : this(state.CurrentTemperature, state.Steak) { }

        public Burnt(double currentTemperature, Steak steak)
        {
            this.currentTemperature = currentTemperature;
            this.steak = steak;
            isSafe = true;

            lowerTemperature = 74.0;
            upperTemperature = double.MaxValue;
        }

        public override void DecreaseTemperature(double degrees)
        {
            currentTemperature -= degrees;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemperature < lowerTemperature)
                steak.State = new WellDone(this);

        }

        public override void IncreaseTemperature(double degrees)
        {
            currentTemperature += degrees;
            DonenessCheck();
        }
    }
}
