using Adapter.Legacy;

namespace Adapter
{
    /// <summary>
    /// The Adapter class, which wraps the Meats class and
    /// initializes that class's values.
    /// </summary>
    public class MeatDetails : Meats
    {
        private MeatsDatabase meatsDatabase;

        public MeatDetails(string name) : base(name)
        {
        }

        public override void LoadData()
        {
            meatsDatabase = new MeatsDatabase();
            SafeCookingTemperatureFahrenheit = meatsDatabase.GetSafeCookingTemperature(MeatName);
            SafeCookingTemperatureCelsius = FahrenheitToCelsius(SafeCookingTemperatureFahrenheit);
            CaloriesPerOunce = meatsDatabase.GetCaloriesPerOunce(MeatName);
            CaloriesPerGram = PoundsToGrams(CaloriesPerOunce);
            ProteinPerOunce = meatsDatabase.GetProteinPerOunce(MeatName);
            ProteinPerGram = PoundsToGrams(ProteinPerOunce);

            base.LoadData();
            Console.WriteLine($" Safe Cooking Temperature (Fahrenheit): {SafeCookingTemperatureFahrenheit}");
            Console.WriteLine($" Safe Cooking Temperature (Celcius): {SafeCookingTemperatureCelsius}");
            Console.WriteLine($" Calories per Ounce: {CaloriesPerOunce}");
            Console.WriteLine($" Calories per Gram: {CaloriesPerGram}");
            Console.WriteLine($" Protein per Ounce: {ProteinPerOunce}");
            Console.WriteLine($" Protein per Gram: {ProteinPerGram}");
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 0.55555;
        }

        private double PoundsToGrams(double pounds)
        {
            return pounds * 0.0283 / 1000;
        }
    }
}
