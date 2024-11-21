namespace Dp.Behavioral.Visitor;

internal interface IVisitor
{
    void VisitBook(Book book);

    void VisitPencil(Pencil pencil);
}
