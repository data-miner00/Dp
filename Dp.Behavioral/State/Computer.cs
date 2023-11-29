namespace Dp.Behavioral.State;

internal partial class Computer
{
    private State state = new Off();

    private void SetState(State state)
    {
        this.state = state;
    }

    public void PressPowerButton()
    {
        this.state.PressPowerButton(this);
    }
}

internal partial class Computer
{
    private interface State
    {
        void PressPowerButton(Computer computer);
    }

    private class Off : State
    {
        public void PressPowerButton(Computer computer)
        {
            // perform some operation
            computer.SetState(new On());
        }
    }

    private class On : State
    {
        private bool charging;

        public void PressPowerButton(Computer computer)
        {
            if (charging)
            {
                computer.SetState(new Standby());
            }
            else
            {
                computer.SetState(new Off());
            }
        }
    }

    private class Standby : State
    {
        public void PressPowerButton(Computer computer)
        {
            computer.SetState(new On());
        }
    }
}
