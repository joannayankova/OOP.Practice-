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
            switch (this.CustumerType)
            {
                case CustomerType.Company:
                    {
                        if (months > 2)
                        {
                            return base.CalculateInterest(months);
                        }

                        return 0;
                       
                    }
                case CustomerType.Individual:
                    {
                        if (months > 3)
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
