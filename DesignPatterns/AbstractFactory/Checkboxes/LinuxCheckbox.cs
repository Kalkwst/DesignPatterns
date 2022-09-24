namespace AbstractFactory.Checkboxes
{
    /// <summary>
    /// All product families have the same varieties (Linux/MacOS/Windows)
    /// 
    /// This is a variant of a checkbox.
    /// </summary>
    public class LinuxCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Successfully created a Linux checkbox");
        }
    }
}
