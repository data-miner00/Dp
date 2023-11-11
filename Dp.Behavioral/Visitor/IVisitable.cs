namespace Dp.Behavioral.Visitor
{
    public interface IVisitable
    {
        double Accept(IVisitor visitor);
    }
}
