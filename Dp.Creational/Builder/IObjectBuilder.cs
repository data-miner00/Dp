namespace Dp.Creational.Builder;

public interface IObjectBuilder<out T>
    where T : class, new()
{
    T Build();
}
