namespace Dp.Behavioral.Visitor;

using System;

internal sealed class TaxVisitor : IVisitor
{
    public void VisitBook(Book book)
    {
        const double TaxRate = 5;
        var tax = book.OriginalPrice * TaxRate / 100;
        var total = book.OriginalPrice + tax;

        book.ComputedPrice = total;
        Console.WriteLine("This book is {0} with tax {1} total {2}.", book.OriginalPrice, tax, total);
    }

    public void VisitPencil(Pencil pencil)
    {
        const double TaxRate = 25;
        var tax = pencil.OriginalPrice * TaxRate / 100;
        var total = pencil.OriginalPrice + tax;

        pencil.ComputedPrice = total;
        Console.WriteLine("This pencil is {0} with tax {1} total {2}.", pencil.OriginalPrice, tax, total);
    }
}
