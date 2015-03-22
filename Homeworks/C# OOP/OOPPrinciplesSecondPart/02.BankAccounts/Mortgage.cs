namespace _02.BankAccounts
{
    class Mortgage : Account
    {
        //Constructors
        public Mortgage(Customer owner, decimal startBalance, decimal interestRate) 
            :base(owner, startBalance, interestRate)
        {
        }

        //Methods
        public override decimal CalculateInterestAmount()
        {
            if (this.Owner.Type == CustomerType.Individual && this.Months < 6)
            {
                return 0;
            }

            if (this.Owner.Type == CustomerType.Company && this.Months <= 12)
            {
                return (base.CalculateInterestAmount() / 2);
            }

            return base.CalculateInterestAmount();
        }
    }
}
