namespace AbstractFactory.Panels
{
    /// <summary>
    /// All product families have the same varieties (Linux/MacOS/Windows)
    /// 
    /// This is a variant of a panel.
    /// </summary>
    public class MacOSPanel : IPanel
    {
        public void Paint()
        {
            Console.WriteLine("Successfully created a MacOSPanel");
        }
    }
}
