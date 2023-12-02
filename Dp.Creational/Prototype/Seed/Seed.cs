namespace Dp.Creational.Prototype.Seed;

using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

public abstract class Seed
{
    /// <summary>
    /// Any clone methods should be implemented by child itself!
    /// </summary>
    /// <returns></returns>
    public abstract Seed Copy();

    /// <summary>
    /// Creates a shallow copy of itself.
    /// </summary>
    /// <returns>The shallow copy of itself.</returns>
    public Seed ShallowClone()
    {
        return (Seed)this.MemberwiseClone();
    }

    public Seed DangerDeepClone()
    {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
        var formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete

        using var stream = new MemoryStream();

        formatter.Serialize(stream, this);
        stream.Seek(0, SeekOrigin.Begin);

        return (Seed)formatter.Deserialize(stream);
    }

    public virtual Seed? SafeDeepClone()
    {
        var objectAsJson = JsonConvert.SerializeObject(this);
        return JsonConvert.DeserializeObject<Seed>(objectAsJson);
    }
}
