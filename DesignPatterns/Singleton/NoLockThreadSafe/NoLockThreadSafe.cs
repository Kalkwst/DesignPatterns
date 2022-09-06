namespace Singleton.NoLockThreadSafe
{
    public sealed class NoLockThreadSafe
    {
        private static NoLockThreadSafe instance = new NoLockThreadSafe();

        // Explicit static constructor to force the C#
        // compiler not to mark the type as beforefieldinit
        static NoLockThreadSafe() { }

        private NoLockThreadSafe(){}

        public static NoLockThreadSafe Instance
        {
            get { return instance; }
        }

        public void Ring()
        {
            Console.WriteLine("Ding! Order Up!");
        }
    }
}
