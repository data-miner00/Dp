namespace Dp.Behavioral.State;

internal sealed class BankAccount
{
    public BankAccount()
    {
        this.State = new NormalState(0, this);
    }

    public IBankAccountState State { get; set; }

    public double Balance => this.State.Balance;

    public void Deposit(double amount)
    {
        this.State.Deposit(amount);
    }

    public void Withdraw(double amount)
    {
        this.State.Withdraw(amount);
    }
}
