namespace Dp.Behavioral.Visitor;

internal sealed class Pencil : IVisitable
{
    public double OriginalPrice { get; set; }

    public double ComputedPrice { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitPencil(this);
    }
}
