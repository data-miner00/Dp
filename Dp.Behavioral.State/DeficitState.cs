namespace Dp.Behavioral.State;

using System;

internal sealed class DeficitState : IBankAccountState
{
    public DeficitState(double balance, BankAccount bankAccount)
    {
        this.Balance = balance;
        this.BankAccount = bankAccount;
    }

    public double Balance { get; private set; }

    public BankAccount BankAccount { get; }

    public void Deposit(double amount)
    {
        this.Balance += amount;
        if (this.Balance > 0)
        {
            this.BankAccount.State = new NormalState(this.Balance, this.BankAccount);
        }
    }

    public void Withdraw(double amount)
    {
        throw new InvalidOperationException("Not allowed");
    }
}
