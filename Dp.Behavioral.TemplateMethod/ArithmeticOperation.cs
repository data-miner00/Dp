namespace Dp.Behavioral.TemplateMethod;

internal abstract class ArithmeticOperation
{
    private const int Num1 = 5;
    private const int Num2 = 13;

    /// <summary>
    /// Initializes a new instance of the <see cref="ArithmeticOperation"/> class.
    /// </summary>
    protected ArithmeticOperation()
    {
        this.Answer = this.Calculate(Num1, Num2);
    }

    /// <summary>
    /// Gets the answer of the arithmetic operation.
    /// </summary>
    public int Answer { get; }

    /// <summary>
    /// Calculates the arithmetic operation.
    /// </summary>
    /// <param name="num1">The number 1.</param>
    /// <param name="num2">The number 2.</param>
    /// <returns>The result.</returns>
    public abstract int Calculate(int num1, int num2);
}
