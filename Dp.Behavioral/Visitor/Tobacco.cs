namespace Dp.Behavioral.Visitor
{
    public class Tobacco : IVisitable
    {
        public double Price { get; set; }

        public Tobacco(double price)
        {
            this.Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
