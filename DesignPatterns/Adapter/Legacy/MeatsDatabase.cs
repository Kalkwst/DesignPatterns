namespace Adapter.Legacy
{
    public enum TemperatureType
    {
        Fahrenheit,
        Celsius
    }

    /// <summary>
    /// The legacy API must be converted to the new structure
    /// </summary>
    public class MeatsDatabase
    {
        public float GetSafeCookingTemperature(string meat)
        {
            return meat.ToLower() switch
            {
                "beef" or "pork" => 145f,
                "chicken" or "turkey" => 165f,
                _ => 165f,
            };
        }

        public int GetCaloriesPerOunce(string meat)
        {
            return meat.ToLower() switch
            {
                "beef" => 71,
                "pork" => 69,
                "chicken" => 66,
                "turkey" => 38,
                _ => 0,
            };
        }

        public double GetProteinPerOunce(string meat)
        {
            return meat.ToLower() switch
            {
                "beef" => 7.33f,
                "pork" => 7.67f,
                "chicken" => 8.57f,
                "turkey" => 8.5f,
                _ => 0f,
            };
        }
    }
}
