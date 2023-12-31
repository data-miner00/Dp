namespace Dp.Structural.Adapter.V2;

/// <summary>
/// Example of object adapter.
/// </summary>
internal class CityFromExternalSystem
{
    public string Name { get; set; }

    public int Inhabitants { get; set; }

    public CityFromExternalSystem(string name, int inhabitants)
    {
        Name = name;
        Inhabitants = inhabitants;
    }
}

/// <summary>
/// This is an adaptee.
/// </summary>
internal class ExternalSystem
{
    public CityFromExternalSystem GetCity()
    {
        return new("Antwerp", 100_000);
    }
}

internal class City
{
    public string FullName { get; set; }

    public long Inhabitants { get; set; }

    public City(string fullName, long inhabitants)
    {
        FullName = fullName;
        Inhabitants = inhabitants;
    }
}

/// <summary>
/// This is a target.
/// </summary>
internal interface ICityAdapter
{
    City GetCity();
}

/// <summary>
/// This is an adapter.
/// </summary>
internal class CityAdapter : ICityAdapter
{
    private readonly ExternalSystem externalSystem = new();

    public City GetCity()
    {
        var incompatibleCity = this.externalSystem.GetCity();

        return new($"{incompatibleCity.Name} name!", incompatibleCity.Inhabitants);
    }
}
