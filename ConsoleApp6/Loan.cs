using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   public class Loan : IAccount
    {
        public Loan(CostumerType costumer)
        {
            Costumer = costumer;
        }

        public double Balance { get; private set; }
        public CostumerType Costumer { get; set; }
        public double Interest_rate { get; private set; }

        public double CalculateInterestRate(int mounths, double interestRate)
        {
            switch (this.Costumer)
            {
                case CostumerType.Company:
                    {
                        if (mounths > 2)
                        {
                            this.Interest_rate=(mounths * interestRate);
                        }

                        return this.Interest_rate;
                    }
                case CostumerType.Individual:
                    {
                        if (mounths > 3)
                        {
                            this.Interest_rate=(this.Balance * interestRate);
                        }
                        return this.Interest_rate;
                    }

                default:
                    throw new Exception("Please first initialize type of the client");

            }
        }

        public void Depositing(double money)
        {
            this.Balance += money;
        }

        
    }
}
