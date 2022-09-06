namespace Singleton.DoubleCheckLocking
{
    public sealed class DoubleCheckLocking
    {
        private static DoubleCheckLocking instance = null;
        private static object lockpad = new object();

        // Private Constructor
        private DoubleCheckLocking() { }

        public static DoubleCheckLocking Instance
        {
            get
            {
                // First check
                if(instance == null)
                {
                    // Locking the padlock
                    lock (lockpad)
                    {
                        if(instance == null)
                            instance = new DoubleCheckLocking();
                    }
                }

                return instance;
            }
        }
        public void Ring()
        {
            Console.WriteLine("Ding! Order Up!");
        }
    }
}
