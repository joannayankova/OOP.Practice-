using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class MortgageAccount : Account, ICanDeposit
    {
        public MortgageAccount(CustomerType custumerType, double interestRate) : base(custumerType, interestRate)
        {
        }

        public override double CalculateInterest(int months)
        {
            switch (this.CustumerType)
            {
                case CustomerType.Company:
                    {
                        if (months < 12)
                        {
                            return base.CalculateInterest(months)/2;
                        }
                        else
                            return base.CalculateInterest(months);
                    }
                case CustomerType.Individual:
                    {
                        if (months > 6)
                        {
                            return base.CalculateInterest(months);
                        }
                        return 0;
                    }

                default:
                    throw new Exception("Please first initialize type of the client");

            }
        }
    }
}

