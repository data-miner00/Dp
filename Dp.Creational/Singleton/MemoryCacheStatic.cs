namespace Dp.Creational.Singleton
{
    internal class MemoryCacheStatic
    {
        private static MemoryCacheStatic instance;

        static MemoryCacheStatic()
        {
            instance = new MemoryCacheStatic();
        }

        private MemoryCacheStatic()
        {
            Console.WriteLine("Created");
        }

        public static MemoryCacheStatic Create()
        {
            return instance;
        }
    }
}
