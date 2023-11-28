namespace Dp.Behavioral.Observer;

internal class Alarm2 : IObservable<int>, IDisposable
{
    private readonly List<IObserver<int>> watchers = [];

    private int index = 0;

    public IDisposable Subscribe(IObserver<int> observer)
    {
        watchers.Add(observer);
        return this;
    }

    public void Notify()
    {
        if (this.index > 3)
        {
            this.watchers.ForEach(x => x.OnCompleted());
            return;
        }

        watchers.ForEach(x => x.OnNext(this.index++));
    }

    public void Dispose()
    {
        this.watchers.Clear();
    }
}

internal class FireStation2 : IObserver<int>
{
    public void Alert(Alarm2 value)
    {
        Console.WriteLine(nameof(FireStation2) + " RESPONDING!");
    }

    public void OnCompleted()
    {
        Console.WriteLine(nameof(FireStation2) + " COMPLETED!");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine(nameof(FireStation2) + " FAILED!");
    }

    public void OnNext(int value)
    {
        Console.WriteLine(nameof(FireStation2) + " NEXT!");
    }
}

internal static class Usage2
{
    public static void Main()
    {
        var alarm = new Alarm2();

        alarm.Subscribe(new FireStation2());

        alarm.Notify();
        alarm.Notify();
        alarm.Notify();
    }
}
