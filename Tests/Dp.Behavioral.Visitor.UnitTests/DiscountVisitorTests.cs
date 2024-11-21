namespace Dp.Behavioral.Visitor.UnitTests;

public sealed class DiscountVisitorTests
{
    private readonly DiscountVisitor visitor = new();

    [Fact]
    public void VisitBook_WithBook_CalculateSubtotal()
    {
        var book = new Book { OriginalPrice = 300 };

        this.visitor.VisitBook(book);

        Assert.Equal(150, book.ComputedPrice);
    }

    [Fact]
    public void VisitPencil_WithPencil_CalculateSubtotal()
    {
        var pencil = new Pencil { OriginalPrice = 70 };

        this.visitor.VisitPencil(pencil);

        Assert.Equal(52.5, pencil.ComputedPrice);
    }
}
