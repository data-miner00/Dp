namespace Dp.Creational.Singleton
{
    internal class MemoryCacheThreadSafe
    {
        private static readonly Lazy<MemoryCacheThreadSafe> instance
            = new(() => new MemoryCacheThreadSafe());

        public static MemoryCacheThreadSafe Instance => instance.Value;
    }
}
