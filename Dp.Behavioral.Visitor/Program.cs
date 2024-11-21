namespace Dp.Behavioral.Visitor;

internal static class Program
{
    public static void Main(string[] args)
    {
        var book = new Book { OriginalPrice = 300 };
        var pencil = new Pencil { OriginalPrice = 70 };

        var taxVisitor = new TaxVisitor();
        var discountVisitor = new DiscountVisitor();

        book.Accept(taxVisitor);
        book.Accept(discountVisitor);

        pencil.Accept(taxVisitor);
        pencil.Accept(discountVisitor);
    }
}
