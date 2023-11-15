namespace Dp.Creational.Builder;

public interface IPrimitiveBuilder<out T>
{
    T Build();
}
