namespace State.State
{
    /// <summary>
    /// A Concrete State class.
    /// </summary>
    public class Uncooked : Doneness
    {
        public Uncooked(Doneness state)
        {
            currentTemperature = state.CurrentTemperature;
            steak = state.Steak;

            lowerTemperature = 0;
            upperTemperature = 48.9;
            isSafe = false;
        }

        public override void DecreaseTemperature(double degrees)
        {
            currentTemperature -= degrees;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemperature > upperTemperature)
                steak.State = new Rare(this);
        }

        public override void IncreaseTemperature(double degrees)
        {
            currentTemperature += degrees;
            DonenessCheck();
        }
    }
}
