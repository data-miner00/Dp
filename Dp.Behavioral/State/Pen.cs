namespace Dp.Behavioral.State;

internal partial class Pen
{
    private State state = new Idle();

    private void SetState(State state)
    {
        this.state = state;
    }

    public void OnClick()
    {
        this.state.OnClick(this);
    }

    public void OnClickFinish()
    {
        this.state.OnClickFinish(this);
    }

    public void OnMove()
    {
        this.state.OnMove(this);
    }
}

internal partial class Pen
{
    private interface State
    {
        void OnMove(Pen pen);
        void OnClick(Pen pen);
        void OnClickFinish(Pen pen);
    }

    private class Idle : State
    {
        public void OnClick(Pen pen)
        {
            pen.SetState(new Writing());
        }

        public void OnClickFinish(Pen pen)
        {
            // do nth
        }

        public void OnMove(Pen pen)
        {
            // do nth
        }
    }

    private class Writing : State
    {
        public void OnClick(Pen pen)
        {
            // draw harder
        }

        public void OnClickFinish(Pen pen)
        {
            pen.SetState(new Idle());
        }

        public void OnMove(Pen pen)
        {
            // draw on canvas
        }
    }
}
