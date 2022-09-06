namespace Singleton.FullyLazyInstantiation
{
    public sealed class FullyLazyInstantiation
    {
        private FullyLazyInstantiation() { }

        public static FullyLazyInstantiation Instance { get { return Nested.Instance; } }

        private class Nested
        {
            // Explicit static constructor to force the C#
            // compiler not to mark the type as beforefieldinit
            static Nested() { }

            internal static readonly FullyLazyInstantiation Instance = new FullyLazyInstantiation();
        }

        public void Ring()
        {
            Console.WriteLine("Ding! Order Up!");
        }
    }
}
