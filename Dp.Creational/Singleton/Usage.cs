namespace Dp.Creational.Singleton
{
    internal class Usage
    {
        public static void Main()
        {
            int size = 8;
            var tasks = new Task[size];

            for (int i = 0; i < size; i++)
            {
                tasks[i] = Task.Run(() => MemoryCache.Create());
            }
            Task.WaitAll(tasks);
        }

        public static void Main2()
        {
            int size = 10;
            var tasks = new Task[size];
            for (int i = 0;i < size; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    var c = MemoryCacheLock.Create();
                    if (!c.Contains("job_id", "job1"))
                    {
                        Console.WriteLine("Big Operation");
                    }
                });
            }

            Task.WaitAll(tasks);
        }

        public static void Main3()
        {
            int size = 10;
            var tasks = new Task[size];
            for (int i = 0;i < size; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    var c = MemoryCacheLock.Create();
                    if (!c.AcquireKey("job_id", "job1"))
                    {
                        Console.WriteLine("Big Operation");
                    }
                });
            }

            Task.WaitAll(tasks);
        }
    }
}
