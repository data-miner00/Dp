namespace Dp.Creational.Singleton
{
    internal class MemoryCache
    {
        private static MemoryCache? instance;

        private MemoryCache()
        {
            Console.WriteLine("Created");
        }

        public static MemoryCache Create()
        {
            return instance ??= new MemoryCache();
        }
    }
}
