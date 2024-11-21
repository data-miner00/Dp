namespace Dp.Behavioral.State.UnitTests;

public sealed class BankAccountTests
{
    private readonly BankAccount bankAccount = new();

    [Fact]
    public void Deposit_NormalState_BalanceIncreased()
    {
        Assert.Equal(0f, this.bankAccount.Balance);

        this.bankAccount.Deposit(300f);

        Assert.Equal(300f, this.bankAccount.Balance);
    }

    [Fact]
    public void Withdraw_NormalState_BalanceDecreased()
    {
        this.bankAccount.Deposit(300f);
        Assert.Equal(300f, this.bankAccount.Balance);

        this.bankAccount.Withdraw(100f);

        Assert.Equal(200f, this.bankAccount.Balance);
    }

    [Fact]
    public void Withdraw_NormalStateDeficit_BecomesDeficitState()
    {
        this.bankAccount.Deposit(300f);
        Assert.Equal(300f, this.bankAccount.Balance);
        Assert.IsType<NormalState>(this.bankAccount.State);

        this.bankAccount.Withdraw(450f);
        Assert.Equal(-150f, this.bankAccount.Balance);
        Assert.IsType<DeficitState>(this.bankAccount.State);
    }

    [Fact]
    public void Withdraw_DeficitState_Throws()
    {
        this.bankAccount.Withdraw(1f);
        Assert.Equal(-1f, this.bankAccount.Balance);
        Assert.IsType<DeficitState>(this.bankAccount.State);

        Assert.Throws<InvalidOperationException>(() => this.bankAccount.Withdraw(1f));
    }

    [Fact]
    public void Deposit_DeficitStateRepented_BecomesNormalState()
    {
        this.bankAccount.Withdraw(1f);
        Assert.Equal(-1f, this.bankAccount.Balance);
        Assert.IsType<DeficitState>(this.bankAccount.State);

        this.bankAccount.Deposit(2f);
        Assert.Equal(1f, this.bankAccount.Balance);
        Assert.IsType<NormalState>(this.bankAccount.State);
    }
}
