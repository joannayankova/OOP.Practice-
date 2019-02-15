using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            bank.OpenDepositAccount(CustomerType.Individual);
            bank.OpenLoanAccount(CustomerType.Company);
            bank.OpenMortgageAccount(CustomerType.Individual);

         foreach(var account in bank.Accounts)
            {
                Console.WriteLine(account.CalculateInterest(4));
            }

        }
    }
}
