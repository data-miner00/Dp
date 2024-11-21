namespace Dp.Behavioral.Visitor;

internal sealed class Book : IVisitable
{
    public double OriginalPrice { get; set; }

    public double ComputedPrice { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitBook(this);
    }
}
