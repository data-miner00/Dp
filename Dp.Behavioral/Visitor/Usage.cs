namespace Dp.Behavioral.Visitor
{
    internal static class Usage
    {
        internal static void Main()
        {
            var taxCalculator = new TaxVisitor();
            var taxCutCalculator = new TaxHolidayVisitor();

            var milk = new Necessity(3.47);
            var vodka = new Liquor(11.99);
            var cigars = new Tobacco(19.99);

            Console.WriteLine(milk.Accept(taxCalculator));
            Console.WriteLine(vodka.Accept(taxCalculator));
            Console.WriteLine(cigars.Accept(taxCalculator));

            Console.WriteLine(milk.Accept(taxCutCalculator));
            Console.WriteLine(vodka.Accept(taxCutCalculator));
            Console.WriteLine(cigars.Accept(taxCutCalculator));
        }
    }
}
