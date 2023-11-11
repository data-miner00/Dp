namespace Dp.Behavioral.Visitor
{
    public class Liquor : IVisitable
    {
        public double Price { get; private set; }

        public Liquor(double price)
        {
            this.Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
