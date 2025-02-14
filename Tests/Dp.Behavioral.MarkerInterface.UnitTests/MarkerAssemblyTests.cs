namespace Dp.Behavioral.MarkerInterface.UnitTests;

using System.Reflection;

public sealed class MarkerAssemblyTests
{
    private readonly Assembly assembly = typeof(IMarker).Assembly;

    [Fact]
    public void GetTypesThatInheritsMarkerInterfaceOnly()
    {
        var markedTypes = this.assembly
            .GetTypes()
            .Where(t => t.IsAssignableTo(typeof(IMarker)) && t.IsClass)
            .ToList();

        Assert.Equal(2, markedTypes.Count);
    }
}
