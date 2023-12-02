namespace Dp.Creational.UnitTests.AbstractFactory;

using Dp.Creational.AbstractFactory;

public class ShoppingCartTests
{
    [Fact]
    public void BelgiumFactory_ShouldReturnExpectedPrice()
    {
        var belgiumFactory = new BelgiumShoppingCartPurchaseFactory();

        var client = new ShoppingCart(belgiumFactory);

        client.CalculateCosts().Should().Be(180);
    }

    [Fact]
    public void FranceFactory_ShouldReturnExpectedPrice()
    {
        var franceFactory = new FranceShoppingCartPurchaseFactory();

        var client = new ShoppingCart(franceFactory);

        client.CalculateCosts().Should().Be(205);
    }
}