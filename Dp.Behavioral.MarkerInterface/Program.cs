namespace Dp.Behavioral.MarkerInterface;

using System.Reflection;

internal class Program
{
    static void Main(string[] args)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        var markerClasses = assembly
            .GetTypes()
            .Where(t => typeof(IMarker).IsAssignableFrom(t) && t.IsClass);

        foreach (var markedClassType in markerClasses)
        {
            Console.WriteLine("Constructing " + markedClassType.Name);

            var obj = Activator.CreateInstance(markedClassType);
        }
    }
}
