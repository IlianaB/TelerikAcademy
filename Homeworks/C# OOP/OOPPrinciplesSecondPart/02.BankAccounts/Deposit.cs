namespace _02.BankAccounts
{
    using System;

    class Deposit : Account, IWithdrawable
    {
        //Constructors
        public Deposit(Customer owner, decimal startBalance, decimal interestRate) 
                :base(owner, startBalance, interestRate)
        {
        }

        //Methods
        public override decimal CalculateInterestAmount()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount();
        }

        public void Withdraw(decimal withdrawedSum)
        {
            if (withdrawedSum <= 0)
            {
                throw new ArgumentException("You cannot withdraw a negative or a zero sum!");
            }

            this.Balance -= withdrawedSum;
        }
    }
}
