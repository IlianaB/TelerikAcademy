namespace _02.BankAccounts
{
    public interface IRemunerable
    {
        decimal InterestRate { get; set; }
        decimal CalculateInterestAmount();
    }
}
