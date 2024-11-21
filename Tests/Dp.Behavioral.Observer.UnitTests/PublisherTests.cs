namespace Dp.Behavioral.Observer.UnitTests;

public class PublisherTests
{
    private readonly Publisher publisher = new("initial");

    [Fact]
    public void Subscribe_NewAction_RegisteredSuccessfully()
    {
        bool isFirstActionExecuted = false, isSecondActionExecuted = false;

        this.publisher.Content = "Updated!!";

        Assert.False(isFirstActionExecuted);
        Assert.False(isSecondActionExecuted);

        this.publisher.Subscribe(FirstAction);
        this.publisher.Subscribe(SecondAction);

        this.publisher.Content = "Updated again!!";

        Assert.True(isFirstActionExecuted);
        Assert.True(isSecondActionExecuted);

        void FirstAction(string newContent)
        {
            Console.WriteLine("Lets go " + newContent);
            isFirstActionExecuted = true;
        }

        void SecondAction(string newContent)
        {
            Console.WriteLine("Haha " + newContent);
            isSecondActionExecuted = true;
        }
    }
}
