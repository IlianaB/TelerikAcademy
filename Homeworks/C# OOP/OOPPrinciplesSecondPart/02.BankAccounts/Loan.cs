namespace _02.BankAccounts
{
    class Loan : Account
    {
        //Constructors
         public Loan(Customer owner, decimal startBalance, decimal interestRate) 
                :base(owner, startBalance, interestRate)
        {
        }

        //Methods
        public override decimal CalculateInterestAmount()
        {
            if (this.Owner.Type == CustomerType.Individual && this.Months < 3)
            {
                return 0;
            }

            if (this.Owner.Type == CustomerType.Company && this.Months < 2)
            {
                return 0;
            }

            return base.CalculateInterestAmount();
        }
    }
}
