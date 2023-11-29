namespace Dp.Behavioral.Strategy;

internal class Process
{
    public void Setup(Action<Process> setup) => setup(this);
}

internal class AdHoc
{
    static void Main()
    {
        var process = new Process();

        process.Setup(p =>
        {
            // ad hoc strategy
        });
    }
}
