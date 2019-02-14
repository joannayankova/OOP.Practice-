namespace ConsoleApp6
{
    public abstract class Account : ICanDeposit
    {
        public Account(CustomerType costumerType, double interestRate)
        {
            CostumerType = costumerType;
            InterestRate = interestRate;
        }

        public double Balance { get; protected set; }

        public double InterestRate { get; private set; }

        public CustomerType CostumerType { get; private set; }

        public virtual double CalculateInterest(int mounths)
        {
            return mounths * InterestRate;
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

