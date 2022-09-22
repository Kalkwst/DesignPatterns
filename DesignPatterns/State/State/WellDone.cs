using State.Context;

namespace State.State
{
    public class WellDone : Doneness
    {
        public WellDone(Doneness state) : this(state.CurrentTemperature, state.Steak) { }

        public WellDone(double currentTemperature, Steak steak)
        {
            this.currentTemperature = currentTemperature;
            this.steak = steak;
            isSafe = true;

            lowerTemperature = 68.4;
            upperTemperature = 73.9;
        }

        public override void DecreaseTemperature(double degrees)
        {
            currentTemperature -= degrees;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemperature < lowerTemperature)
                steak.State = new Well(this);

            if (currentTemperature > upperTemperature)
                steak.State = new Burnt(this);
        }

        public override void IncreaseTemperature(double degrees)
        {
            currentTemperature += degrees;
            DonenessCheck();
        }
    }
}
