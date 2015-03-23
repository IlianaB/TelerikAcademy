//Problem 2. Bank accounts

//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.

namespace _02.BankAccounts
{
    using System;

    class Test
    {
        static void Main()
        {
            Bank bank = new Bank("BestBank");

            Customer newOwner = new Customer("Pesho", CustomerType.Individual);
            Deposit myDeposit = new Deposit(newOwner, 1200, 3.45m);
            bank.AddAccount(myDeposit);

            Customer secondOwner = new Customer("Gosho", CustomerType.Company);
            Mortgage GoshoLoan = new Mortgage(secondOwner, 500, 5.50m);
            bank.AddAccount(GoshoLoan);

            Console.WriteLine(bank);

            for (int i = 0; i < bank.AllAccounts.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Account {0}: ", i + 1);
                Console.WriteLine(bank.AllAccounts[i]);
            }
        }
    }
}
