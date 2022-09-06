namespace Singleton.NaiveSingleton
{
    /// <summary>
    /// Naive Singleton
    /// </summary>
    public sealed class NaiveSingleton
    {
        private static NaiveSingleton instance = null;

        // Private constructor
        private NaiveSingleton() { }

        // Property to access the Instance
        public static NaiveSingleton Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new NaiveSingleton();

                return instance;
            }
        }

        public void Ring()
        {
            Console.WriteLine("Ding! Order Up!");
        }
    }
}
