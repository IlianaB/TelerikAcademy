namespace _02.BankAccounts
{
    using System;

    class Test
    {
        static void Main()
        {
            Bank bank = new Bank("BestBank");

            Customer newOwner = new Customer("Pesho", CustomerType.Individual);
            Deposit myDeposit = new Deposit(newOwner, 100, 3.45m);
            bank.AddAccount(myDeposit);

            Customer secondOwner = new Customer("Gosho", CustomerType.Company);
            Mortgage GoshoLoan = new Mortgage(secondOwner, -500, 5.50m);
            bank.AddAccount(GoshoLoan);

            Console.WriteLine(myDeposit.CalculateInterestAmount());
            Console.WriteLine(GoshoLoan.CalculateInterestAmount());
        }
    }
}
