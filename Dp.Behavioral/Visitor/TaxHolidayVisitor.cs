namespace Dp.Behavioral.Visitor
{
    public class TaxHolidayVisitor : IVisitor
    {
        public double Visit(Liquor item)
        {
            return item.Price + (item.Price * 0.02);
        }

        public double Visit(Tobacco item)
        {
            return item.Price + (item.Price * 0.04);
        }

        public double Visit(Necessity item)
        {
            return item.Price + (item.Price * 0.01);
        }
    }
}
