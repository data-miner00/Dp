namespace Dp.Creational.FactoryMethod
{
    internal abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }

        public override string ToString() => GetType().Name;
    }

    internal class CountryDiscountService : DiscountService
    {
        private readonly string countryCode;

        public CountryDiscountService(string countryCode)
        {
            this.countryCode = countryCode;
        }

        public override int DiscountPercentage
        {
            get
            {
                return this.countryCode switch
                {
                    "BE" => 20,
                    _ => 10,
                };
            }
        }
    }

    internal class CodeDiscountService : DiscountService
    {
        private readonly string discountCode;

        public CodeDiscountService(string discountCode)
        {
            this.discountCode = discountCode;
        }

        public override int DiscountPercentage => 5;
    }

    internal abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    internal class CountryDiscountFactory : DiscountFactory
    {
        private readonly string countryCode;

        public CountryDiscountFactory(string countryCode)
        {
            this.countryCode = countryCode;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(countryCode);
        }
    }

    internal class CodeDiscountFactory : DiscountFactory
    {
        private readonly string discountCode;

        public CodeDiscountFactory(string discountCode)
        {
            this.discountCode = discountCode;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(discountCode);
        }
    }
}
