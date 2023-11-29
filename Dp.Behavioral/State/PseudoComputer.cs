namespace Dp.Behavioral.State;

/// <summary>
/// This pattern should be applied to something with many behaviour.
/// When the state changed, the behaviour changes as well.
/// </summary>
internal class PseudoComputer
{
    private int state = 0;
    private bool charging = true;

    public void PressPowerButton()
    {
        // off
        if (this.state == 0)
        {
            this.state = 1;
            Console.WriteLine("Turning off computer");
            return;
        }

        // on
        if (this.state == 1)
        {
            if (charging)
            {
                this.state = 2;
                Console.WriteLine("Hibernating computer");
                return;
            }

            state = 0;
            return;
        }

        // hibernated
        this.state = 1;
    }
}
