namespace Singleton.DotNetLazy
{
    public sealed class DotNetLazy
    {
        private static readonly Lazy<DotNetLazy> lazy =
            new Lazy<DotNetLazy>(() => new DotNetLazy());

        public static DotNetLazy Instance => lazy.Value;

        private DotNetLazy() { }
    }
}
