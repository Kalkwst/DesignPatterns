using State.Context;

namespace State.State
{
    public class Medium : Doneness
    {
        public Medium(Doneness state) : this(state.CurrentTemperature, state.Steak) { }

        public Medium(double currentTemperature, Steak steak)
        {
            this.currentTemperature = currentTemperature;
            this.steak = steak;
            isSafe = true;

            lowerTemperature = 57.3;
            upperTemperature = 62.8;
        }

        public override void DecreaseTemperature(double degrees)
        {
            currentTemperature -= degrees;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemperature < lowerTemperature)
                steak.State = new MediumRare(this);

            if (currentTemperature > upperTemperature)
                steak.State = new Well(this);
        }

        public override void IncreaseTemperature(double degrees)
        {
            currentTemperature += degrees;
            DonenessCheck();
        }
    }
}
