namespace AbstractFactory.Buttons
{
    /// <summary>
    /// All product families have the same varieties (Linux/MacOS/Windows).
    /// 
    /// This is a Linux variant of a button.
    /// </summary>
    public class LinuxButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Successfully created a LinuxButton");
        }
    }
}
