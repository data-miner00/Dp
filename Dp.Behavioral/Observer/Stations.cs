namespace Dp.Behavioral.Observer;

internal interface IWatcher<T>
{
    public void Alert(T value);
}

internal class FireStation : IWatcher<Alarm>
{
    public void Alert(Alarm value)
    {
        Console.WriteLine(nameof(FireStation) + " RESPONDING!");
    }
}

internal class PoliceStation : IWatcher<Alarm>
{
    public void Alert(Alarm value)
    {
        Console.WriteLine(nameof(PoliceStation) + " RESPONDING!");
    }
}

internal class HospitalStation : IWatcher<Alarm>
{
    public void Alert(Alarm value)
    {
        Console.WriteLine(nameof(HospitalStation) + " RESPONDING!");
    }
}

internal class Alarm
{
    private readonly List<IWatcher<Alarm>> watchers = new();

    public void AddWatcher(IWatcher<Alarm> watcher)
    {
        watchers.Add(watcher);
    }

    public void Notify()
    {
        foreach (var watcher in watchers)
        {
            watcher.Alert(this);
        }
    }
}

internal static class Usage
{
    public static void Main()
    {
        var alarm = new Alarm();

        alarm.AddWatcher(new FireStation());
        alarm.AddWatcher(new PoliceStation());
        alarm.AddWatcher(new HospitalStation());
        alarm.Notify();
    }
}
