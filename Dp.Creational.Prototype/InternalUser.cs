namespace Dp.Creational.Prototype;

using System.Text.Json;

internal sealed class InternalUser : IUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Department { get; set; }

    /// <inheritdoc/>
    public object Clone()
    {
        return new InternalUser
        {
            FirstName = this.FirstName,
            LastName = this.LastName,
            Department = this.Department,
        };
    }

    public IUser DeepClone()
    {
        var json = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<InternalUser>(json)!;
    }
}
