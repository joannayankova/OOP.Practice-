using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Deposit : IAccount
    {
        public Deposit(CostumerType costumer)
        {
            Costumer = costumer;
        }

        public double Balance { get; private set; }

        public CostumerType Costumer { get; set; }

        public double CalculateInterestRate(int mounths, double interestRate)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return mounths * interestRate;
            }
            else
                return 0;
        }

        public void Depositing(double money)
        {
            this.Balance += money;
        }

        public void WithDrawing(double money)
        {

            if (money > this.Balance) throw new BalanceException("Not enough balance");
            Balance -= money;

        }
    }
}
