using System;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account
//using the appropriate data types and descriptive names.

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Georgi";
            string middleName = "Dimitrov";
            string lastName = "Dimitrov";
            decimal balance = 12348.75m;
            string bankName = "Invest Bank";
            string iban = "BG64UNCR76301078660913";
            ulong firstCard = 72036854775807;
            ulong secondCard = 29223372036854;
            ulong thirdCard = 90369302495902;

            Console.WriteLine("Bank account owner: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Balance: {0} lv.", balance);
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Credit cards: {0},  {1}, {2}", firstCard, secondCard, thirdCard);
        }
    }
}
