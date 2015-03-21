namespace _02.StudentsAndWorkers
{
    using System;
    using System.Text;

    abstract class Human
    {
        //Fields
        public string firstName;
        public string lastName;

        //Constructors
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The first name cannot be null!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("The first name should have at least two letters");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The last name cannot be null!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("The last name should have at least two letters");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("{0} {1}", this.FirstName, this.LastName));

            return result.ToString();
        }
        
    }
}
