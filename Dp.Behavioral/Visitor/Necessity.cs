namespace Dp.Behavioral.Visitor
{
    public class Necessity : IVisitable
    {
        public double Price { get; private set; }

        public Necessity(double price)
        {
            this.Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
