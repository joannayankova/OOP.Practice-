using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class DepositAccount : Account, ICanWithdraw
    {
        public DepositAccount(CustomerType custumerType, double interestRate) : base(custumerType, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
               return base.CalculateInterest(months);
            }
            else
                return 0;
        }

        public void Withdraw(double ammount)
        {
            if (ammount > this.Balance) throw new BalanceException("Not enough balance");

            Balance -= ammount;
        }
    }
}
