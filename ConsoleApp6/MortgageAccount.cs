using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class MortgageAccount : Account, ICanDeposit
    {
        public MortgageAccount(CustomerType costumerType, double interestRate) : base(costumerType, interestRate)
        {
        }

        public override double CalculateInterestRate(int mounths, double interestRate)
        {
            switch (this.Costumer)
            {
                case CostumerType.Company:
                    {
                        if (mounths < 12)
                        {
                            this.Interest_rate = ((mounths * interestRate) / 2);
                        }
                        else
                        {
                            this.Interest_rate = (mounths * interestRate);
                        }
                        return this.Interest_rate;

                    }
                case CostumerType.Individual:
                    {
                        if (mounths > 6)
                        {
                            this.Interest_rate = (this.Balance * interestRate);
                        }
                        return this.Interest_rate;
                    }

                default:
                    throw new Exception("Please first initialize type of the client");

            }
        }
    }
}

