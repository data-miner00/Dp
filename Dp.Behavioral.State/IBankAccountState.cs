namespace Dp.Behavioral.State;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal interface IBankAccountState
{
    double Balance { get;  }

    BankAccount BankAccount { get; }

    void Deposit(double amount);

    void Withdraw(double amount);
}
