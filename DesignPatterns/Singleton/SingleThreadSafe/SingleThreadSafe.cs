namespace Singleton.SingleThreadSafe
{
    public sealed class SingleThreadSafe
    {
        private static SingleThreadSafe instance = null;
        private static object lockpad = new object();

        // Private Constructor
        private SingleThreadSafe() { }

        // Property to access the Instance
        public static SingleThreadSafe Instance
        {
            get
            {
                // locking the shared object
                lock (lockpad)
                {
                    if(instance == null)
                        instance = new SingleThreadSafe();

                    return instance;
                }
            }
        }

        public void Ring()
        {
            Console.WriteLine("Ding! Order Up!");
        }
    }
}
