namespace AbstractFactory.Buttons
{
    /// <summary>
    /// All product families have the same varieties (Linux/MacOS/Windows).
    /// 
    /// This is a MacOS variant of a button.
    /// </summary>
    public class MacOSButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Successfully created a MacOSButton");
        }
    }
}
