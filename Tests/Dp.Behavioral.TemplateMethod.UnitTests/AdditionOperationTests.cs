namespace Dp.Behavioral.TemplateMethod.UnitTests;

public sealed class AdditionOperationTests
{
    [Fact]
    public void Initialize_AdditionOperation_ExpectAdded()
    {
        var operation = new AdditionOperation();

        Assert.Equal(18, operation.Answer);
    }
}
