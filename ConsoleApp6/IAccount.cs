using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public interface IAccount
    {

        double Balance { get; }

        CostumerType Costumer { get; set; }

        void Depositing(double money);

        double CalculateInterestRate(int mounths,double interestRate);

    }
}
