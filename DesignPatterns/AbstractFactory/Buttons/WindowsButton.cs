namespace AbstractFactory.Buttons
{
    /// <summary>
    /// All product families have the same varieties (Linux/MacOS/Windows).
    /// 
    /// This is a Windows variant of a button.
    /// </summary>
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Successfully created a WindowsButton");
        }
    }
}
