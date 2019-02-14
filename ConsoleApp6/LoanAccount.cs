using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class LoanAccount : Account
    {
        public LoanAccount(CustomerType costumerType, double interestRate) : base(costumerType, interestRate)
        {
        }

        public override double CalculateInterest(int months)
        {
            switch (this.CostumerType)
            {
                case CustomerType.Company:
                    {
                        if (months > 2)
                        {
                            return base.CalculateInterest(months);
                        }

                        return 0;
                    }
                //case CostumerType.Individual:
                //    {
                //        if (months > 3)
                //        {
                //            this.Interest_rate = (this.Balance * interestRate);
                //        }
                //        return this.Interest_rate;
                //    }

                default:
                    throw new Exception("Please first initialize type of the client");

            }
        }
    }
}
