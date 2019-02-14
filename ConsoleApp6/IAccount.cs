using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public interface ICanDeposit
    {
        void Deposit(double amount);
    }

    public interface ICanWithdraw
    {
        void Withdraw(double amount);
    }
}
