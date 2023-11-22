namespace Dp.Creational.Singleton
{
    internal class MemoryCacheLock
    {
        private static int i = 0;
        private static MemoryCacheLock instance;
        private static object cacheLock = new();

        private readonly Dictionary<string, string> registry;

        private MemoryCacheLock()
        {
            Console.WriteLine("Created");
        }

        public static MemoryCacheLock Create()
        {
            if (instance == null)
            {
                lock (cacheLock)
                {
                    instance ??= new MemoryCacheLock();
                }
            }

            return instance;
        }

        public bool Contains(string key, string value)
        {
            return registry.Contains(KeyValuePair.Create(key, value));
        }

        public void Write(string key, string value)
        {
            registry[key] = value;
        }

        public bool AcquireKey(string key, string value)
        {
            lock (cacheLock)
            {
                if (Contains(key, value))
                {
                    return false;
                }
                Write(key, value);

                return true;
            }
        }
    }
}
