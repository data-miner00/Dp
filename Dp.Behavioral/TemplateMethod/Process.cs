namespace Dp.Behavioral.TemplateMethod;

internal class Process
{
    public void Start()
    {
        this.Step1();
        this.Step2();
        this.Step3();
    }

    protected virtual void Step1()
    {
        Console.WriteLine("Step 1");
    }

    protected virtual void Step2()
    {
        Console.WriteLine("Step 2");
    }

    protected virtual void Step3()
    {
        Console.WriteLine("Step 3");
    }
}

internal class Variation1 : Process
{
    protected override void Step1()
    {
        Console.WriteLine("Step 1 overwritten");
    }
}

internal class Variation2 : Process
{
    protected override void Step3()
    {
        Console.WriteLine("Additional pre step 3");
        base.Step3(); // using the `base` also known as hooks
    }
}

internal class Variation3 : Process
{
    protected override void Step1()
    {
        Console.WriteLine("Overitten Step1");
    }

    protected override void Step3()
    {
        Console.WriteLine("Pre step 3");
        base.Step3();
    }
}
