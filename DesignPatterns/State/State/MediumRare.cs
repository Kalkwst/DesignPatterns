using State.Context;

namespace State.State
{
    public class MediumRare : Doneness
    {
        public MediumRare(Doneness state) : this(state.CurrentTemperature, state.Steak) { }

        public MediumRare(double currentTemperature, Steak steak)
        {
            this.currentTemperature = currentTemperature;
            this.steak = steak;
            isSafe = true;

            lowerTemperature = 54.5;
            upperTemperature = 57.2;
        }

        public override void DecreaseTemperature(double degrees)
        {
            currentTemperature -= degrees;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemperature < lowerTemperature)
                steak.State = new Rare(this);

            if (currentTemperature > upperTemperature)
                steak.State = new Medium(this);
        }

        public override void IncreaseTemperature(double degrees)
        {
            currentTemperature += degrees;
            DonenessCheck();
        }
    }
}
