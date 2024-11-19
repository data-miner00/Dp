namespace Dp.Behavioral.TemplateMethod.UnitTests;

public sealed class SubtractOperationTests
{
    [Fact]
    public void Initialize_SubtractOperation_ExpectSubtracted()
    {
        var operation = new SubtractionOperation();

        Assert.Equal(-8, operation.Answer);
    }
}
