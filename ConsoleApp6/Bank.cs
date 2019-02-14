using System.Collections.Generic;

namespace ConsoleApp6
{
    public class Bank
    {
        public double InterestRate { get; } = 2;

        public List<Account> Accounts { get; } = new List<Account>();

        public void OpenMortgageAccount(CustomerType costumerType)
        {
            Accounts.Add(new MortgageAccount(costumerType, InterestRate));
        }

        public void OpenLoanAccount(CustomerType costumerType)
        {
            Accounts.Add(new LoanAccount(costumerType, InterestRate));
        }

        public void OpenDepositAccount(CustomerType costumerType)
        {
            Accounts.Add(new DepositAccount(costumerType, InterestRate));
        }
    }
}

