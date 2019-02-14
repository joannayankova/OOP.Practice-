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
            List<IAccount> Accounts = new List<IAccount>();

            Mortgage account1 = new Mortgage(CostumerType.Company);
            Loan account2 = new Loan(CostumerType.Individual);
            Deposit account3 = new Deposit(CostumerType.Individual);

            Accounts.Add(account1);

            Accounts.Add(account2);

            Accounts.Add(account3);

            account1.Depositing(3000);

            account2.Depositing(6000);

            account3.Depositing(12000);

            try
            {
                account3.WithDrawing(30000);
            }
            catch(BalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            account1.CalculateInterestRate(6, 0.2);

            account2.CalculateInterestRate(2, 0.5);

            account3.CalculateInterestRate(5, 0.8);


        }
    }
}
