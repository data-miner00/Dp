namespace Dp.Behavioral.State;

using System;

internal class NormalState : IBankAccountState
{
    public NormalState(double balance, BankAccount bankAccount)
    {
        this.Balance = balance;
        this.BankAccount = bankAccount;
    }

    public double Balance { get; set; }

    public BankAccount BankAccount { get; set; }

    public void Deposit(double amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(double amount)
    {
        this.Balance -= amount;
        if (this.Balance < 0)
        {
            this.BankAccount.State = new DeficitState(this.Balance, this.BankAccount);
        }
    }
}
