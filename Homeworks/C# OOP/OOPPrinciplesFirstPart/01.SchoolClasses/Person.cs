namespace _01.SchoolClasses
{
    using System;

    public abstract class Person
    {
        //Fields
        private string name;

        //Constructors
        public Person(string name)
        {
            this.Name = name;
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
                if (value.Length < 2)
                {
                    throw new ArgumentException("The name should have at least two letters!");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("The name cannot be null!");
                }

                this.name = value; 
            }
        }
    }
}
