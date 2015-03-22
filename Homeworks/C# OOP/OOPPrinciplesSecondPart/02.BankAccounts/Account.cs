namespace _02.BankAccounts
{
    using System;

    abstract class Account : IRemunerable, IDepositable
    {
        //Fields
        private Customer owner;
        private decimal balance;
        private DateTime openDate;
        private decimal interestRate;

        //Constructors
        public Account(Customer owner, decimal startBalance, decimal interestRate)
        {
            this.owner = owner;
            this.balance = startBalance;
            this.InterestRate = interestRate;
            this.openDate = DateTime.Now;
        }

        //Properties
        internal Customer Owner
        {
            get 
            {
                return this.owner; 
            }
        }

        public decimal Balance
        {
            get 
            { 
                return this.balance; 
            }
            set 
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest rate should be a positive value!");
                }

                this.interestRate = value;
            }
        }

        public int Months
        {
            get
            {
                return (this.openDate.Year * 12 + this.openDate.Month)
                       - (DateTime.Now.Year * 12 + DateTime.Now.Month);
            }
        }

        //Methods
        public virtual decimal CalculateInterestAmount()
        {
            return (this.Months * this.InterestRate);
        }

        public void Deposite(decimal receivedSum)
        {
            if (receivedSum <= 0)
            {
                throw new ArgumentException("You cannot deposite a negative or a zero sum!");
            }

            this.Balance += receivedSum; 
        }
    }
}
