namespace Dp.Behavioral.Visitor;

internal sealed class DiscountVisitor : IVisitor
{
    public void VisitBook(Book book)
    {
        const double DiscountRate = 50;
        var discount = book.OriginalPrice * DiscountRate / 100;
        var total = book.OriginalPrice - discount;

        book.ComputedPrice = total;
        Console.WriteLine("This book is {0} with discount {1} total {2}.", book.OriginalPrice, discount, total);
    }

    public void VisitPencil(Pencil pencil)
    {
        const double DiscountRate = 25;
        var discount = pencil.OriginalPrice * DiscountRate / 100;
        var total = pencil.OriginalPrice - discount;

        pencil.ComputedPrice = total;
        Console.WriteLine("This pencil is {0} with discount {1} total {2}.", pencil.OriginalPrice, discount, total);
    }
}
