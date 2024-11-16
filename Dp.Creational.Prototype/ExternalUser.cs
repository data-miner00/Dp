namespace Dp.Creational.Prototype;

using System.Text.Json;

internal sealed class ExternalUser : IUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Company { get; set; }

    /// <inheritdoc/>
    public object Clone()
    {
        // Using built-in memberwise clone (shallow copy)
        return (ExternalUser)this.MemberwiseClone();
    }

    public IUser DeepClone()
    {
        var json = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<ExternalUser>(json)!;
    }
}
