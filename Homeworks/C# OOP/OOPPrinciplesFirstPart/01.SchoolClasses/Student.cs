namespace _01.SchoolClasses
{
    using System;

    public class Student : Person, ICommentable
    {
        //Fields
        private string classNumber;
        private string comment;

        //Constructors
        public Student(string name, string classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, string classNumber, string comment)
            : this(name, classNumber)
        {
            this.Comment = comment;
        }

        //Properties
        public string ClassNumber
        {
            get 
            { 
                return this.classNumber; 
            }
            private set 
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("The class number should with exactly six letters!");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("The class number cannot be null!");
                }

                this.classNumber = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            private set
            {
                this.comment = value;
            }
        }
    }
}
