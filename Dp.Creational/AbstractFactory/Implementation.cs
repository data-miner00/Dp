namespace Dp.Creational.AbstractFactory;

/// <summary>
/// Abstract Factory
/// </summary>
internal interface IShoppingCartPurchaseFactory
{
    IDiscountService CreateDiscountService();

    IShippingCostsService CreateShippingCostsService();
}

/// <summary>
/// Abstract Product
/// </summary>
interface IDiscountService
{
    int DiscountPercentage { get; }
}

/// <summary>
/// Abstract Product
/// </summary>
interface IShippingCostsService
{
    decimal ShippingCosts { get; }
}

/// <summary>
/// Concrete Product
/// </summary>
class BelgiumDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
}

/// <summary>
/// Concrete Product
/// </summary>
class FranceDiscountService :IDiscountService
{
    public int DiscountPercentage => 10;
}

/// <summary>
/// Concrete Product
/// </summary>
class BelgiumShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 20;
}

/// <summary>
/// Concrete Product
/// </summary>
class FranceShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 25;
}

/// <summary>
/// Concrete factory
/// </summary>
class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new BelgiumDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new BelgiumShippingCostsService();
    }
}

/// <summary>
/// Concrete factory
/// </summary>
class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new FranceDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new FranceShippingCostsService();
    }
}

/// <summary>
/// Client
/// </summary>
class ShoppingCart
{
    private readonly IDiscountService discountService;
    private readonly IShippingCostsService shippingCostsService;
    private int orderCosts;

    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        this.discountService = factory.CreateDiscountService();
        this.shippingCostsService = factory.CreateShippingCostsService();

        this.orderCosts = 200;
    }

    public decimal CalculateCosts()
    {
        return this.orderCosts - (this.orderCosts / 100 * this.discountService.DiscountPercentage) + this.shippingCostsService.ShippingCosts;
    }
}
