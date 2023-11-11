namespace Dp.Behavioral.Visitor
{
    public class TaxVisitor : IVisitor
    {
        public double Visit(Liquor item)
        {
            return item.Price + (item.Price * 0.05);
        }

        public double Visit(Tobacco item)
        {
            return item.Price + (item.Price * 0.08);
        }

        public double Visit(Necessity item)
        {
            return item.Price + (item.Price * 0.03);
        }
    }
}
