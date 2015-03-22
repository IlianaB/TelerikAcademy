namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;

    class Bank
    {
        //Fields
        private string name;
        private IList<Account> allAccounts;

        //Constructors
        public Bank(string name)
        {
            this.Name = name;
            this.allAccounts = new List<Account>();
        }

        //Properties
        public string Name
        {
            get 
            { 
                return this.name; 
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the bank cannot be null!");
                }

                this.name = value; 
            }
        }

        internal IList<Account> AllAccounts
        {
            get 
            {
                return new List<Account>(this.allAccounts);
            }
        }
      
        //Methods
        public void AddAccount(Account newAccount)
        {
            this.allAccounts.Add(newAccount);
        }
    }
}
