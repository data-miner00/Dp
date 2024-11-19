namespace Dp.Behavioral.TemplateMethod;

internal sealed class AdditionOperation : ArithmeticOperation
{
    /// <inheritdoc/>
    public override int Calculate(int num1, int num2)
    {
        return num1 + num2;
    }
}
