namespace Dp.Behavioral.State;

internal static class Program
{
    public static void Main(string[] args)
    {
        var bank = new BankAccount();
        bank.Deposit(100);
        bank.Withdraw(300);
        bank.Withdraw(200);
    }
}
